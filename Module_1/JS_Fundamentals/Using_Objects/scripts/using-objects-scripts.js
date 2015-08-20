function problem_1() {
    problemNumber.innerHTML = 'Problem 1';
    input1.style.width = '210px';
    input1.style.visibility = 'visible';
    input1.placeholder = '1. X, Y / X1, Y1, X2, Y2';
    input2.style.width = '210px';
    input2.style.visibility = 'visible';
    input2.placeholder = '2. X, Y / X1, Y1, X2, Y2';
    input3.style.width = '210px';
    input3.style.visibility = 'visible';
    input3.placeholder = '3. X1, Y1, X2, Y2';

    jsConsole.writeLine('Problem 1. Planar coordinates');
    jsConsole.writeLine(' - Write functions for working with shapes in standard Planar coordinate system.');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Points are represented by coordinates P(X, Y)');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))');
    jsConsole.writeLine(' - Calculate the distance between two points.');
    jsConsole.writeLine(' - Check if three segment lines can form a triangle.');
    jsConsole.writeLine('');
    jsConsole.writeLine(' - Input rules');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; 1 field (1.) - show coordinates of Point [X, Y] or Line([X1, Y1], [X2, Y2]);)');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; 2 fields (1., 2.)- need 2 points P1[X1, Y1] and P2[X2, Y2]) - calculate distance between them;)');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; 3 fields (1., 2., 3.)- need 3 lines L1([X1, Y1], [X2, Y2]), L2([X1, Y1], [X2, Y2]), L3([X1, Y1], [X2, Y2]) - check if they can form a triangle;');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&bull; use numbers separated by "," - just numbers - for example: (point)  5, 8 (x, y) ; (line) 4, 3, 6, 7 (x1, y1, x2, y2);)');
    solutionText();

    submit.onclick = function () {
        var firstField = input1.value.split(',').map(Number);
        var secondField = input2.value.split(',').map(Number);
        var thirdField = input3.value.split(',').map(Number);

        if (firstField.length === 2 && secondField.length === 2 && thirdField.length === 1) { // equal to one because .map(Number) converts the empty string to array [0]

            // calculate distance between 2 points
            if (checkInput(firstField) && checkInput(secondField)) {
                var firstPoint = pointBuilder(firstField),
                    secondPoint = pointBuilder(secondField),
                    distance = calculateDistance(firstPoint, secondPoint);
                jsConsole.writeLine('');
                jsConsole.writeLine('P1' + firstPoint + ', P2' + secondPoint);
                jsConsole.writeLine('Distance: ' + distance.toFixed(2));
                playWhat();

            } else {
                incorrectInput();
            }

        } else if (firstField.length === 2 && secondField.length === 1 && thirdField.length === 1) {

            // show coordinates of the point
            if (checkInput(firstField)) {
                var singlePoint = pointBuilder(firstField);
                jsConsole.writeLine('');
                jsConsole.writeLine('Single point: P' + singlePoint);
                playWhat();
            } else {
                incorrectInput()
            }

        } else if (firstField.length === 4 && secondField.length === 4 && thirdField.length === 4) {

            // check if 3 lines can form a triangle
            if (checkInput(firstField) && checkInput(secondField)) {
                var firstLine = lineBuilder(pointBuilder(firstField.slice(0, 2)), pointBuilder(firstField.slice(2))),
                    secondLine = lineBuilder(pointBuilder(secondField.slice(0, 2)), pointBuilder(secondField.slice(2))),
                    thirdLine = lineBuilder(pointBuilder(thirdField.slice(0, 2)), pointBuilder(thirdField.slice(2))),
                    isTriangle;

                isTriangle = canMakeTriangle(firstLine, secondLine, thirdLine);
                jsConsole.writeLine('');
                jsConsole.writeLine('First line: L1' + firstLine + ' length: ' + firstLine.length().toFixed(2));
                jsConsole.writeLine('First line: L2' + secondLine + ' length: ' + secondLine.length().toFixed(2));
                jsConsole.writeLine('First line: L3' + thirdLine + ' length: ' + thirdLine.length().toFixed(2));
                jsConsole.writeLine('L1, L2, L3 form triangle: ' + isTriangle);
                playWhat();
            } else {
                incorrectInput();
            }


        } else if (firstField.length === 4 && secondField.length === 1 && thirdField.length === 1) {

            // show coordinates of the line
            if (checkInput(firstField)) {
                var pointOne = pointBuilder(firstField.slice(0, 2)),
                    pointTwo = pointBuilder(firstField.slice(2)),
                    singleLine = lineBuilder(pointOne, pointTwo);

                jsConsole.writeLine('');
                jsConsole.writeLine('Single line: L' + singleLine);
                playWhat();
            } else {
                incorrectInput()
            }

        } else {
            incorrectInput();
        }

        function checkInput(arr) {

            var isCorrect = arr.some(function (item) {
                return isNaN(item)
            });
            return !isCorrect;
        }

        function pointBuilder(arr) {
            return {
                x: arr[0],
                y: arr[1],
                toString: function () {
                    return '[' + this.x + ', ' + this.y + ']';
                }
            }
        }

        function lineBuilder(pointOne, pointTwo) {
            return {
                firstPoint: pointOne,
                secondPoint: pointTwo,
                length: function () {
                    return calculateDistance(this.firstPoint, this.secondPoint)
                },
                toString: function () {
                    return '(' + this.firstPoint + ', ' + this.secondPoint + ')';
                }
            }
        }

        function calculateDistance(firstPoint, secondPoint) {
            return Math.sqrt((firstPoint.x - secondPoint.x) * (firstPoint.x - secondPoint.x) + (firstPoint.y - secondPoint.y) * (firstPoint.y - secondPoint.y))
        }

        function canMakeTriangle(lineOne, lineTwo, lineThree) {
            // Take the two shortest line lengths and add them together,if they are larger than the third length, than it can form a triangle
            var lines = [lineOne.length(), lineTwo.length(), lineThree.length()];
            lines.sort(function (a, b) {
                return a - b
            });
            return ((lines[0] + lines[1]) > lines[2])

        }
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '300px';
    input1.style.visibility = 'visible';
    input1.placeholder = '[elements] separated by comma ","';
    input2.style.width = '100px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'To remove';

    jsConsole.writeLine('Problem 2. Remove elements');
    jsConsole.writeLine(' - Write a function that removes all elements with a given value.');
    jsConsole.writeLine(' - Attach it to the array type.');
    solutionText();


    submit.onclick = function () {

        var input = input1.value.split(/[ ,]/g).filter(function (item) {
                return item !== ''; // do not using !!item, because if the value is number 0 it will accept it as false and will be filtered
            }),
            toRemove = input2.value,
            keepInput = input.slice(0);

        // the magic - it is in this function scope because it fucked my other arrays when I had to use for in cycle... :)
        Array.prototype.remove = function (element) {
            for (var i = 0, len = this.length; i < len; i += 1) {
                if (this[i] === element) {
                    this.splice(i, 1);
                    i -= 1;
                    len -= 1;
                }
            }
        };

        // remove works on the instance of the array
        input.remove(toRemove);

        printResult();
        function printResult() {
            jsConsole.writeLine('');
            jsConsole.writeLine('Input: ' + keepInput);
            jsConsole.writeLine('Element to remove: ' + toRemove);
            jsConsole.writeLine('With removed element: ' + input);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_3() {

    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Deep copy');
    jsConsole.writeLine(' - Write a script that finds the maximal sequence of equal elements in an array.');
    jsConsole.writeLine(' - Write a function that makes a deep copy of an object.');
    jsConsole.writeLine(' - The function should work for both primitive and reference types.');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {
        var originalObj = {
                firstName: 'John',
                lastName: 'Doe',
                stats: {
                    health: 100,
                    mana: 100,
                    abilities: {
                        range: 300,
                        magic: false
                    }
                },
                toString: function () {
                    return 'firstName: ' + this.firstName +
                        '<br/>' + 'firstName: ' + this.lastName +
                        '<br/>' + 'stats: ' +
                        '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- health: ' + this.stats.health +
                        '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- mana: ' + this.stats.mana +
                        '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- abilities: ' +
                        '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; range: ' + this.stats.abilities.range +
                        '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; magic: ' + this.stats.abilities.magic;
                }
            },
            originalPrimitive = 1111111111,
            clonedObj,
            clonedPrimitive;

        // Function that makes the magic of cloning
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

        // Reference type clone check
        jsConsole.writeLine('');
        jsConsole.writeLine('Original  object : ' + '<br/>' + originalObj);
        clonedObj = deepClone(originalObj);
        jsConsole.writeLine('');
        jsConsole.writeLine('Cloned object : ' + '<br/>' + clonedObj);
        jsConsole.writeLine('');
        clonedObj.firstName = 'Johnny ';
        clonedObj.lastName = 'Walker';
        clonedObj.stats.health = 700;
        clonedObj.stats.abilities.range = 100;
        clonedObj.stats.abilities.magic = true;
        jsConsole.writeLine('Cloned object after changes: ' + '<br/>' + clonedObj);
        jsConsole.writeLine('');
        jsConsole.writeLine('Original object after changes: ' + '<br/>' + originalObj);
        jsConsole.writeLine('');

        // Primitive type clone check
        jsConsole.writeLine('Original primitive: ' + originalPrimitive);
        clonedPrimitive = deepClone(originalPrimitive);
        jsConsole.writeLine('Cloned primitive: ' + clonedPrimitive);
        clonedPrimitive = 999999999999;
        jsConsole.writeLine('Cloned primitive after changes: ' + clonedPrimitive);
        jsConsole.writeLine('Original primitive after changes: ' + originalPrimitive);
        jsConsole.writeLine('');

        playWhat();
    }
}

function problem_4() {
    playWorse();
    problemNumber.innerHTML = 'Problem 4';
    input1.style.width = '300px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter property to check';

    jsConsole.writeLine('Problem 4. Has property');
    jsConsole.writeLine(' - Write a function that checks if a given object contains a given property.');
    solutionText();

    // Test object
    var obj = {
        firstName: 'John',
        lastName: 'Doe',
        stats: {
            health: 100,
            mana: 100,
            abilities: {
                range: 300,
                magic: false
            }
        },
        toString: function () {
            return 'firstName: ' + this.firstName +
                '<br/>' + 'firstName: ' + this.lastName +
                '<br/>' + 'stats: ' +
                '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- health: ' + this.stats.health +
                '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- mana: ' + this.stats.mana +
                '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;- abilities: ' +
                '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; range: ' + this.stats.abilities.range +
                '<br/>' + '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; magic: ' + this.stats.abilities.magic;
        }
    };

    // show object's properties on the web page
    jsConsole.writeLine(obj);
    jsConsole.writeLine('');
    jsConsole.writeLine(' - health, mana, abilities, etc are properties of  object "stats" so they are not properties of the main object!!');

    submit.onclick = function () {
        var searchedProperty = input1.value.toString(),
            hasProperty;

        hasProperty = hasProp(obj, searchedProperty);

        function hasProp(obj, property) {
            return obj.hasOwnProperty(property);
        }

        printResult(searchedProperty, hasProperty);

        function printResult(searchedProp, hasProp) {
            jsConsole.writeLine('');
            jsConsole.writeLine('The object has "' + searchedProp + '" property -> ' + hasProp);
            playWhat();
        }
    }
}

function problem_5() {
    problemNumber.innerHTML = 'Problem 5';

    jsConsole.writeLine('Problem 5. Youngest person');
    jsConsole.writeLine(' - Write a function that finds the youngest person in a given array of people and prints his/hers full name');
    jsConsole.writeLine(' - Each person has properties firstname, lastname and age.');
    solutionText();

    var people = [
            personBuilder('Johnny', 'Walker', 28),
            personBuilder('Jack', 'Daniels', 38),
            personBuilder('Mary', 'Jane', 16),
            personBuilder('Lady', 'Gangna', 26)
        ],
        youngest;

    // Person builder
    function personBuilder(fName, lName, age) {
        return {
            firstName: fName,
            lastName: lName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age;
            }
        }
    }

    // display all persons o the browser
    for (var i = 0, len = people.length; i < len; i += 1) {
        jsConsole.writeLine(people[i]);
    }

    jsConsole.writeLine('');
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {
        findYoungest(people);

        // Magic function :)
        function findYoungest(persons) {
            persons.sort(function (a, b) {
                return a.age - b.age
            });
            jsConsole.writeLine('');
            jsConsole.writeLine('Youngest: ' + persons[0]);
        }
    }
}

function problem_6() {
    playFinale();
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6.');
    jsConsole.writeLine(' - Write a function that groups an array of people by age, first or last name.');
    jsConsole.writeLine(' - The function must return an associative array, with keys - the groups, and values - arrays with people in this groups');
    jsConsole.writeLine(' - Use function overloading (i.e. just one function)');
    solutionText();

    var people = [
        personBuilder('Johnny', 'Walker', 28),
        personBuilder('Johnny', 'Daniels', 26),
        personBuilder('Johnny', 'Jane', 16),
        personBuilder('Johnny', 'Gangna', 38),
        personBuilder('Jack', 'Walker', 26),
        personBuilder('Jack', 'Daniels', 38),
        personBuilder('Jack', 'Jane', 26),
        personBuilder('Jack', 'Gangna', 16),
        personBuilder('Mary', 'Jane', 16),
        personBuilder('Mary', 'Jane', 28),
        personBuilder('Mary', 'Walker', 16),
        personBuilder('Mary', 'Daniels', 38),
        personBuilder('Mary', 'Gangna', 16),
        personBuilder('Lady', 'Gangna', 26),
        personBuilder('Lady', 'Walker', 16),
        personBuilder('Lady', 'Daniels', 26),
        personBuilder('Lady', 'Gangna', 38)
    ];

    // Person builder
    function personBuilder(fName, lName, age) {
        return {
            firstName: fName,
            lastName: lName,
            age: age,
            toString: function () {
                return this.firstName + ' ' + this.lastName + ', age: ' + this.age + '<br/>';
            }
        }
    }

    // display all persons o the browser
    for (var i = 0, len = people.length; i < len; i += 1) {
        jsConsole.write(people[i]);

    }

    jsConsole.writeLine('');
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result');
    jsConsole.writeLine('');

    submit.onclick = function () {

        // Magic function :)
        function group(people, sortBy) {

            var grouped = [];

            for (i = 0, len = people.length; i < len; i += 1) {
                var currentProp = people[i][sortBy];
                grouped[currentProp] = grouped[currentProp] || [];
                grouped[currentProp].push(people[i]);
            }
            return grouped;
        }


        var groupedByFname = group(people, 'firstName');
        var groupedByLname = group(people, 'lastName');
        var groupedByAge = group(people, 'age');

        printGroup(groupedByFname, 'First name');
        printGroup(groupedByLname, 'Last name');
        printGroup(groupedByAge, 'age');


        function printGroup(group, sortBY) {
            jsConsole.writeLine('---------------------------------------');
            jsConsole.writeLine('');
            jsConsole.writeLine('Grouped by ' + sortBY);
            jsConsole.writeLine('');
            for (var i in group) {
                jsConsole.writeLine(group[i]);
                jsConsole.writeLine('');
                console.log(group[i]);
            }
            jsConsole.writeLine('');
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


