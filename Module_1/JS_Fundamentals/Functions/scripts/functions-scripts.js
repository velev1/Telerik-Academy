function problem_1() {
    problemNumber.innerHTML = 'Problem 1';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter integer';

    jsConsole.writeLine('Problem 1. English digit');
    jsConsole.writeLine(' - Write a function that returns the last digit of given integer as an English word.');
    solutionText();

    submit.onclick = function () {
        var input = input1.value * 1;

        if (!isNaN(input)) {

            printResult(input, lastDigitToWord(input));
        } else {
            incorrectInput();
        }

        function lastDigitToWord(number) {

            var digit = number % 10;

            switch (digit) {
                case 0:
                    digit = 'zero';
                    break;
                case 1:
                    digit = 'one';
                    break;
                case 2:
                    digit = 'two';
                    break;
                case 3:
                    digit = 'three';
                    break;
                case 4:
                    digit = 'four';
                    break;
                case 5:
                    digit = 'five';
                    break;
                case 6:
                    digit = 'six';
                    break;
                case 7:
                    digit = 'seven';
                    break;
                case 8:
                    digit = 'eight';
                    break;
                case 9:
                    digit = 'nine';
                    break;
            }

            return digit;
        }

        function printResult(number, digit) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Number: ' + number);
            jsConsole.writeLine('Last digit: ' + digit);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter number';

    jsConsole.writeLine('Problem 2. Reverse number');
    jsConsole.writeLine(' - Write a function that reverses the digits of given decimal number.');
    solutionText();

    submit.onclick = function () {

        var input = +input1.value;

        if (!isNaN(input)) {
            printResult(input, reverseDigits(input));
        } else {
            incorrectInput();
        }

        function reverseDigits(number) {
            var i,
                reversed,
                number = number.toString();

            reversed = number.split('').reverse().join('');

            return parseFloat(reversed);
        }

        function printResult(input, reversed) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Input: ' + input);
            jsConsole.writeLine('Reversed: ' + reversed);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_3() {
    input1.style.width = '230px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text';
    input2.style.width = '130px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Searched word';
    check_box.style.visibility = 'visible';
    check_box.style.width = 'auto';
    check_box.checked = false;
    check_label.style.visibility = 'visible';
    check_label.innerHTML = 'Case insensitive';
    check_label.style.width = 'auto';

    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Occurrences of word');
    jsConsole.writeLine(' - Write a function that finds all the occurrences of word in a text.');
    jsConsole.writeLine(' - The search can be case sensitive or case insensitive.');
    jsConsole.writeLine(' - Use function overloading.');
    solutionText();

    caseMatters();
    function caseMatters() {
        if (check_box.checked) {
            check_label.innerHTML = 'Case sensitive';

        } else {
            check_label.innerHTML = 'Case insensitive';
        }
    }

    check_box.onclick = caseMatters;

    submit.onclick = function () {
        var caseSensitive = false,
            text = input1.value,
            searched = input2.value,
            occurrence;

        // Check if the case sensitive check-box is checked
        if (check_box.checked) {
            caseSensitive = true;
        }

        // Calling the function that makes magic and returns the count of the searched word
        occurrence = occurrenceInText(text, searched, caseSensitive);

        // This is the function that makes the magic
        function occurrenceInText(text, searched, caseSensitive) {
            var occurrence = 0,
                index = -1;

            if (!caseSensitive) {
                searched = searched.toLowerCase();
                text = text.toLowerCase();
            }

            // if searched is '' (nothing) the cycle becomes endless so if the length of searched is 0 (falsie) never start the cycle
            while (searched.length) {
                index = text.indexOf(searched, index + 1);
                if (index >= 0) {
                    occurrence += 1;
                } else {
                    break
                }
            }

            return occurrence;
        }

        printResult(text, searched, occurrence, caseSensitive);

        function printResult(text, searched, occurrence) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In text: ' + text);
            jsConsole.writeLine('Case sensitive: ' + caseSensitive);
            jsConsole.writeLine('"' + searched + '" occurs "' + occurrence + '" times!');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_4() {
    problemNumber.innerHTML = 'Problem 4';
    input1.style.width = '150px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter tag name';
    input1.value = 'div';

    jsConsole.writeLine('Problem 4. Number of elements');
    jsConsole.writeLine(' - Write a function to count the number of div elements on the web page');
    jsConsole.writeLine(' - You can change the searched tag (the default value is "div" - just click on the SUBMIT INPUT button to see the result)');
    solutionText();

    submit.onclick = function () {

        var htmlText = document.documentElement.innerHTML,
            tag = input1.value,
            tagCount;


        function tagCounter(text, tag) {

            var regex = new RegExp('<' + tag + ' ', 'g'),
                matches;

            matches = text.match(regex);

            if (matches) {
                return matches.length;
            } else {
                return 0;
            }
        }

        tagCount = tagCounter(htmlText, tag);
        printResult(tag, tagCount);


        function printResult(tag, tagCount) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In current HTML page tag: "' + tag + '"');
            jsConsole.writeLine('Occurs -> ' + tagCount + ' times');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_5() {
    playWorse();
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = '[] separated by comma ","';
    input2.style.width = '140px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Number to check';
    check_box.style.visibility = 'visible';
    check_box.style.width = 'auto';
    check_box.checked = false;
    check_label.style.visibility = 'visible';
    check_label.innerHTML = 'User/Self testing';
    check_label.style.width = 'auto';
    problemNumber.innerHTML = 'Problem 5';

    jsConsole.writeLine('Problem 5. Appearance count');
    jsConsole.writeLine(' - Write a function that counts how many times given number appears in given array.');
    jsConsole.writeLine(' - Write a test function to check if the function is working correctly.');
    solutionText();

    testingMode();
    function testingMode() {
        if (check_box.checked) {
            input2.style.visibility = 'hidden';
            input1.style.visibility = 'hidden';

        } else {
            input2.style.visibility = 'visible';
            input1.style.visibility = 'visible';
        }
    }

    check_box.onclick = testingMode;


    submit.onclick = function () {

        var input = input1.value.split(',').map(Number),
            searchedNumber = +(input2.value),
            count;

        if (check_box.checked) {
            testCounter();
        } else {

            count = countCheck(input, searchedNumber);
            printResult(input, searchedNumber, count);
        }

        function countCheck(array, number) {
            var i,
                length,
                count = 0;

            if (Array.isArray(array)) {

                for (i = 0 , length = array.length; i < length; i += 1) {
                    if (array[i] === number) {
                        count += 1;
                    }
                }

                return count;
            }
        }

        function testCounter() {
            var testArrays = {
                    first: {
                        arr: [1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5],
                        searched: 5,
                        exp: 10
                    },
                    second: {
                        arr: [1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5],
                        searched: 15,
                        exp: 0
                    },
                    third: {
                        arr: [1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5],
                        searched: 0,
                        exp: 1
                    },
                    fourth: {
                        arr: [],
                        searched: 2,
                        exp: 0
                    }
                },
                item;

            for (item in testArrays) {
                var current = testArrays[item],
                    count = countCheck(current.arr, current.searched),
                    selfTest = false;
                if (count === current.exp) {
                    selfTest = true;
                }
                printResult(current.arr, current.searched, count, selfTest);
            }
        }

        function printResult(input, searchedNumber, count, self) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In the array  ->  (' + input + ')');
            jsConsole.writeLine('Number -> ' + searchedNumber);
            jsConsole.writeLine('Occurs -> ' + count + ' times');
            if (self != undefined) {
                jsConsole.writeLine('Self test success: -> ' + self);
            }
            playWhat();
        }
    }
}

function problem_6() {
    input1.style.width = '300px';
    input1.style.visibility = 'visible';
    input1.placeholder = '[numbers] separated by comma ","';
    input2.style.width = '140px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'index';
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6. Larger than neighbours');
    jsConsole.writeLine(' - Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).');
    solutionText();

    submit.onclick = function () {

        var result,
            input = input1.value.split(',').map(Number),
            index = +(input2.value),
            correctInput = true;

        if (isNaN(index) || !input || index >= input.length || index < 0) {
            correctInput = false;
        }

        if (correctInput) {

            result = checkBigNeighbour(input, index);

            printResult(input, index, result);

            function checkBigNeighbour(array, index) {
                if (index <= 0 || index >= (array.length - 1)) {
                    return false;
                } else if (array[index - 1] < array[index] && array[index + 1] < array[index]) {
                    return true;
                }
                return false;
            }

        }
        else {
            incorrectInput();
        }

        function printResult(input, index, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In array -> ' + input);
            jsConsole.writeLine('Number (' + input[index] + ') in index -> ' + index);
            jsConsole.writeLine('Bigger than it\'s two neighbours -> ' + result);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_7() {
    playFinale();
    input1.style.width = '380px';
    input1.style.visibility = 'visible';
    input1.placeholder = '[numbers] separated by comma ","';
    problemNumber.innerHTML = 'Problem 7';

    jsConsole.writeLine('Problem 7. First larger than neighbours');
    jsConsole.writeLine(' - Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.');
    jsConsole.writeLine(' - Use the function from the previous exercise.');
    solutionText();

    submit.onclick = function () {

        var input = input1.value.split(',').map(Number),
            index,
            correctInput = true;

        if (!input) {
            correctInput = false;
        }

        if (correctInput) {

            index = firstBigNeighbour(input);

            printResult(input, index);

            function firstBigNeighbour(array) {
                var i,
                    length;
                for (i = 1, length = array.length - 1; i < length; i += 1) {
                    if(checkBigNeighbour(array, i)){
                        return i;
                    }
                }

                return -1;
            }

            // coping the same function because there are different scopes for the different problems and I can't you it here :)
            function checkBigNeighbour(array, index) {
                if (index <= 0 || index >= (array.length - 1)) {
                    return false;
                } else if (array[index - 1] < array[index] && array[index + 1] < array[index]) {
                    return true;
                }
                return false;
            }

        }
        else {
            incorrectInput();
        }

        function printResult(input, index) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In array -> ' + input);
            if(index > 0){
                jsConsole.writeLine('First bigger than it\' two neighbours (' + input[index] + ') at index -> ' + index);
            }else {
                jsConsole.writeLine('No such number -> ' + index );
            }
            jsConsole.writeLine('');
            playEnding();
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
            problem_5();
            break;
        case 6:
            button_next.disabled = false;
            problem_6();
            break;
        case 7:
            button_next.disabled = true;
            problem_7();
            break;
    }
}

