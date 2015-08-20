function solve() {

    var Course = (function () {
        var _titlePattern = /^([^ ]+([ ]{1}[\S]+)*)$/,
            _studentNamePattern = /^([A-Z]+[a-z]* [A-Z]+[a-z]*)$/;

        function checkPattern(value, pattern, param) {
            if (!(pattern.test(value))) {
                var errorMessage = 'Error: ;nvalid  - ' + param;

                throw new Error(errorMessage);
            }
        }

        function isInteger(num) {
            return num === parseInt(num, 10)
        }

        function checkStudentID(id, students) {
            if (!isInteger(id) ||
                (id < 1) ||
                students.filter(function (st) {
                    return st.id === id;
                }).length === 0) {

                throw new Error('Incorrect student id');
            }
        }

        function checkHomeworkID(id, presentations) {
            if (!isInteger(id) ||
                (id < 1) ||
                (id > presentations.length)) {

                throw new Error('Incorrect homework id');
            }
        }

        function calculateFinalScore(st, totalHomeworkCount) {

            return (st.score * 0.75) + ((totalHomeworkCount / st.homework.length) * 0.25);
        }

        var Course = {
            init: function (title, presentations) {

                this.title = title;
                this.presentations = presentations;
                this._students = [];
                return this;
            },
            addStudent: function (name) {
                var firstName,
                    lastName,
                    studentID;

                checkPattern(name, _studentNamePattern);

                name = name.split(' ');
                firstName = name[0];
                lastName = name[1];
                studentID = this._students.length + 1;

                this._students.push({firstname: firstName, lastname: lastName, id: studentID, score: 0, homework: []})

                return studentID;
            },
            getAllStudents: function () {
                return this._students.slice(0);
            },
            submitHomework: function (studentID, homeworkID) {
                checkStudentID(studentID, this._students);
                checkHomeworkID(homeworkID, this._presentations);

                this._students.forEach(function (st) {
                    if (st.id === studentID) {
                        if (st.homework.indexOf(homeworkID) < 0) {
                            st.homework.push(homeworkID);
                        }
                    }
                })
            },
            pushExamResults: function (results) {
                var currentIDs = {};
                results.forEach(function (result) {
                    checkStudentID(result['StudentID'], this._students);

                    if (currentIDs[result['StudentID']]) {
                        throw new Error('Cheater!!')
                    }

                    if (isNaN(result['Score'])) {
                        throw new Error('Incorrect score format!!')
                    }

                    this._students[result['StudentID'] - 1].score = result['Score'];
                    currentIDs[result['StudentID']] = true;
                })

            },
            getTopStudents: function () {
                var totalHomeworkCount = this._presentations.length,
                    topStudentsCount = 10;

                if (this._students.length < 10) {
                    topStudentsCount = this._students.length;
                }

                return this._students.sort(function (stA, stB) {
                    stA.totaScore = calculateFinalScore(stA, totalHomeworkCount);
                    stB.totaScore = calculateFinalScore(stB, totalHomeworkCount);

                    return stA.totaScore - stB.totaScore;
                }).slice(0, topStudentsCount);
            },
            get title() {
                return this._title;
            },
            set title(title) {
                checkPattern(title, _titlePattern, 'course title');
                this._title = title;
            },
            set presentations(presentations) {
                if (!Array.isArray(presentations) || presentations.length < 1) {
                    throw new Error('The course must have at least one presentation');
                }

                presentations.forEach(function (title) {
                    checkPattern(title, _titlePattern, 'presentation title');
                });

                this._presentations = presentations;
            }
        };

        return Course;
    }());

    return Course;
}

module.exports = solve;
