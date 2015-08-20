// make the array global so to be used from all problem functions
var people = [];

// just in case - global function
function deepClone(obj) {
    if (obj === null || typeof obj !== "object") {
        return obj;
    }

    var temp = obj.constructor();

    for (var key in obj) {
        temp[key] = deepClone(obj[key]);
    }
    return temp;
}

function printPeople(arrayOfPeople) {
    jsConsole.writeLine('');
    arrayOfPeople.forEach(function (person) {
        jsConsole.writeLine(person)
    });
    jsConsole.writeLine('');
}

function problem_1() {
    problemNumber.innerHTML = 'Problem 1';

    jsConsole.writeLine('Problem 1. Make person');
    jsConsole.writeLine(' - Write a function for creating persons');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Each person must have firstname, lastname, age and gender (true is female, false is male)');
    jsConsole.writeLine(' - Generate an array with ten person with different names, ages and genders');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to generate the array');
    jsConsole.writeLine('');

    people = [
        personBuilder('Johnny', 'Walker', 28, false),
        personBuilder('Jack', 'Daniels', 38, false),
        personBuilder('Mary', 'Jane', 16, true),
        personBuilder('Lady', 'Gangna', 26, true),
        personBuilder('Pesho', 'Spirtenski', 15, false),
        personBuilder('Izomrud', 'Traqnkow', 23, false),
        personBuilder('Kaka', 'Papacici', 18, true),
        personBuilder('Petran', 'Smirnov', 26, false),
        personBuilder('Penio', 'Ubavetsa', 20, true),
        personBuilder('Bay', 'Gosho', 56, false),
        personBuilder('Leika', 'Amakuha', 14, true)
    ];

    // Person builder
    function personBuilder(fName, lName, age, gender) {
        return {
            firstName: fName,
            lastName: lName,
            age: age,
            gender: gender,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age + ', gender: ' + this.gender;
            }
        }
    }

    // It used to generate the array onclick but that's risky because the array is necessary fot the next problems, so only display on submit :)
    submit.onclick = function () {

        printPeople(people);
        playWhat();
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';

    jsConsole.writeLine('Problem 2. People of age');
    jsConsole.writeLine(' - Write a function that checks if an array of person contains only people of age (with age 18 or greater)');
    solutionText();
    printPeople(people);
    jsConsole.writeLine(' - Click "SUBMIT INPUT" see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {
        var onlyAdults;

        onlyAdults = people.every(function (person) {
            return person.age >= 18
        });

        jsConsole.writeLine('All people age >= 18: ' + onlyAdults);

        playWhat();
    }
}

function problem_3() {

    playWorse();
    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Underage people');
    jsConsole.writeLine(' - Write a function that prints all underaged persons of an array of person');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Use Array#filter and Array#forEach');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {

        var underAge = [];

        underAge = people.filter(function (person) {
            return person.age < 18
        });

        jsConsole.writeLine('Underaged: ');
        printPeople(underAge); // the function is on the top of document and uses forEach :)
        playWhat();
    }
}

function problem_4() {
    playWorse();
    problemNumber.innerHTML = 'Problem 4';

    jsConsole.writeLine('Problem 4. Average age of females');
    jsConsole.writeLine(' - Write a function that calculates the average age of all females, extracted from an array of persons');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Use Array#filter');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');


    submit.onclick = function () {

        var females = people.filter(function (person) {
                return person.gender
            }),
            averageFemaleAge = females.reduce(function (sum, female) {
                    return sum + female.age
                }, 0) / females.length,
            avrYears = Math.floor(averageFemaleAge),
            avrDays = Math.floor(365 * (averageFemaleAge % 1));

        jsConsole.writeLine('');
        jsConsole.writeLine('Females: ');
        printPeople(females);
        jsConsole.writeLine('Average age: ' + avrYears + ' years and ' + avrDays + ' days');
        playWhat();

    }
}

function problem_5() {
    problemNumber.innerHTML = 'Problem 5';

    jsConsole.writeLine('Problem 5. Youngest person');
    jsConsole.writeLine(' - Write a function that finds the youngest male person in a given array of people and prints his full name');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Use only array methods and no regular loops (for, while)');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/find
    if (!Array.prototype.find) {
        Array.prototype.find = function (predicate) {
            if (this == null) {
                throw new TypeError('Array.prototype.find called on null or undefined');
            }
            if (typeof predicate !== 'function') {
                throw new TypeError('predicate must be a function');
            }
            var list = Object(this);
            var length = list.length >>> 0;
            var thisArg = arguments[1];
            var value;

            for (var i = 0; i < length; i++) {
                value = list[i];
                if (predicate.call(thisArg, value, i, list)) {
                    return value;
                }
            }
            return undefined;
        };
    }

    submit.onclick = function () {

        var cloneOfPeople = deepClone(people),
            youngestMale = cloneOfPeople.sort(function (personA, personB) {
                return personA.age - personB.age
            }).find(function (person) {
                return !person.gender
            });

        jsConsole.writeLine('');
        printPeople(people);
        jsConsole.write('Youngest male: ');
        printPeople([youngestMale]);
        jsConsole.writeLine('-----------------------------------------------');
        playWhat();
    }
}

function problem_6() {
    playFinale();
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6. Group people');
    jsConsole.writeLine(' - Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Use Array#reduce');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {
        var grouped = people.reduce(function (group, person) {
            var currProp = person.firstName[0];
            group[currProp] = group[currProp] || [];
            group[currProp].push(person);
            return group;
        }, {});

        printGroups(grouped, 'first letter');

        function printGroups(groups, sortBY) {
            jsConsole.writeLine('---------------------------------------');
            jsConsole.writeLine('');
            jsConsole.writeLine('Grouped by ' + sortBY);
            jsConsole.writeLine('');
            console.log(groups);
            for (var gr in groups) {
                    printPeople(groups[gr]);
            }
        }
    }
}

function problemSwitch() {
    resetInputFields();
    jsConsole.clearConsole();

    switch (problemCounter) {
        case 1:
            button_prev.disabled = true;
            problem_1();
            break;
        case 2:
            button_prev.disabled = false;
            problem_2();
            break;
        case 3:
            problem_3();
            break;
        case 4:
            problem_4();
            break;
        case 5:
            button_next.disabled = false;
            problem_5();
            break;
        case 6:
            button_next.disabled = true;
            problem_6();
            break;
    }
}



