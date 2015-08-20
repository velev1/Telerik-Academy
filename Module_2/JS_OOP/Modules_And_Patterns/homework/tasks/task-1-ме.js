/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

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

                if(this._students.length < 10){
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


/*


 var validTitles = [
 'Modules and Patterns',
 'Ofcourse, this is a valid title!',
 'No errors hIr.',
 'Moar taitles',
 'Businessmen arrested for harassment of rockers',
 'Miners handed cabbages to the delight of children',
 'Dealer stole Moskvitch',
 'Shepherds huddle',
 'Retired Officers rally',
 'Moulds detonate tunnel',
 'sailors furious'
 ], validNames = [
 'Pesho',
 'Notaname',
 'Johny',
 'Marulq',
 'Keremidena',
 'Samomidena',
 'Medlar',
 'Yglomer',
 'Elegant',
 'Analogical',
 'Bolsheviks',
 'Reddish',
 'Arbitrage',
 'Toyed',
 'Willfully',
 'Transcribing'
 ];

 function getValidTitle() {
 return validTitles[(Math.random() * validTitles.length) | 0];
 }
 function getValidName() {
 return validNames[(Math.random() * validNames.length) | 0];
 };

 var jsoop = Object.create(solve());
 jsoop.init(getValidTitle(), [getValidTitle()]);
 jsoop.addStudent(getValidName() + ' ' + getValidName());

 */