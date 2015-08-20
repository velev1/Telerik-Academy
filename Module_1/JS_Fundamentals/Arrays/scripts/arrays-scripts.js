function problem_1() {
    problemNumber.innerHTML = 'Problem 1';

    jsConsole.writeLine('Problem 1. Increase array members');
    jsConsole.writeLine(' - Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.');
    jsConsole.writeLine(' - Print the obtained array on the console.');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" to see the result!!');
    jsConsole.writeLine('');
    jsConsole.writeLine('');

    submit.onclick = function () {
        var array = [],
            i,
            len = 20;
        for (i = 0; i < len; i += 1) {
            array.push(i * 5);
        }

        jsConsole.writeLine(array.join(', '));
        playWhat();
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter first';
    input2.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter second';


    jsConsole.writeLine('Problem 2. Lexicographically comparison');
    jsConsole.writeLine(' - Write a script that compares two char arrays lexicographically (letter by letter).');
    solutionText();
    submit.onclick = function () {

        var i,
            greater,
            equal = 'first: ',
            first = input1.value.split(''),
            second = input2.value.split(''),
            length = Math.min(first.length, second.length);

        if (length > 0) {

            console.log(first);
            for (i = 0; i <= length; i += 1) {
                if (first[i] !== second[i]) {
                    if (first[i] < second[i]) {
                        greater = first;
                        break
                    } if (first[i] > second[i])  {
                        greater = second;
                        break;
                    }
                }
            }
            if (greater) {
                printResult();
            } else if (first.length === second.length){
                equal = 'equal! ';
                greater = '';
                printResult();
            } else{
                if (first.length < second.length) {
                    greater = first
                } else{
                    greater = second;
                }
                printResult();
            }

        } else {
            incorrectInput();
        }


        function printResult() {
            jsConsole.writeLine('');
            jsConsole.writeLine('First: ' + first);
            jsConsole.writeLine('Second: ' + second);
            jsConsole.writeLine('');
            jsConsole.writeLine('Lexicographically ' + equal + greater);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_3() {
    input1.style.width = '400px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter numbers separated by comma ","';

    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Maximal sequence');
    jsConsole.writeLine(' - Write a script that finds the maximal sequence of equal elements in an array.');
    solutionText();

    submit.onclick = function () {

        var i,
            correctInput = true,
            input = input1.value.split(',').map(Number),
            length = input.length,
            tempMaxSequence = 1,
            maxSequence = 1,
            startIndex = 0,
            endIndex = 0;

        for (i = 0; i < length; i += 1) {

            if (isNaN(input[i] * 1)) {
                correctInput = false;
            }
        }

        if (correctInput) {

            for (i = 1; i < length; i += 1) {

                if (input[i] === input[i - 1]) {


                    tempMaxSequence += 1;

                    if (tempMaxSequence > maxSequence) {

                        maxSequence = tempMaxSequence;

                        startIndex = i - maxSequence + 1;
                        endIndex = i;

                    }
                } else {
                    tempMaxSequence = 1;
                }

            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(input);
            jsConsole.writeLine('Maximal sequence: ' + maxSequence + ' -> ' + input.slice(startIndex, endIndex + 1));
            jsConsole.writeLine('');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_4() {
    input1.style.width = '400px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter numbers separated by comma ","';

    problemNumber.innerHTML = 'Problem 4';

    jsConsole.writeLine('Problem 4. Maximal increasing sequence');
    jsConsole.writeLine(' - Write a script that finds the maximal increasing sequence in an array.');
    solutionText();

    submit.onclick = function () {

        var i,
            correctInput = true,
            input = input1.value.trim().split(',').map(Number),
            length = input.length,
            tempMaxSequence = 1,
            maxSequence = 1,
            startIndex = 0,
            endIndex = 0;

        for (i = 0; i < length; i += 1) {

            if (isNaN(input[i] * 1)) {
                correctInput = false;
            }
        }

        if (correctInput) {

            for (i = 1; i < length; i += 1) {

                if (input[i] > input[i - 1]) {


                    tempMaxSequence += 1;

                    if (tempMaxSequence > maxSequence) {

                        maxSequence = tempMaxSequence;

                        startIndex = i - maxSequence + 1;
                        endIndex = i;

                    }
                } else {
                    tempMaxSequence = 1;
                }

            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(input);
            jsConsole.writeLine('Maximal increasing  sequence: ' + maxSequence + ' -> ' + input.slice(startIndex, endIndex + 1));
            jsConsole.writeLine('');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_5() {
    playWorse();
    input1.style.width = '400px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter numbers separated by comma ","';
    problemNumber.innerHTML = 'Problem 5';

    jsConsole.writeLine('Problem 5. Selection sort');
    jsConsole.writeLine(' - Sorting an array means to arrange its elements in increasing order.');
    jsConsole.writeLine(' - Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.');
    jsConsole.writeLine(' - Hint: Use a second array');
    solutionText();


    submit.onclick = function () {

        var i = 0,
            j = 0,
            min,
            temp = 0,
            correctInput = true,
            input = input1.value.trim().split(',').map(Number),
            length = input.length,
            sorted = [];

        // I'm using second array just to keep the input array for the output. All of the operations are with one array.
        // Check the input and make copy of it at the same time;
        for (i = 0; i < length; i += 1) {
            sorted.push(input[i]);
            if (isNaN(input[i] * 1)) {
                correctInput = false;
            }
        }

        if (correctInput) {

            for (i = 0; i < length; i += 1) {
                console.log('i - ' + i);
                min = sorted[i];

                for (j = i; j < length; j += 1) {

                    if (sorted[j] < min) {
                        min = sorted[j];
                        temp = sorted[i];
                        sorted[i] = min;
                        sorted[j] = temp;
                    }
                }
            }
        } else {
            incorrectInput();
        }

        printResult();

        function printResult() {
            jsConsole.writeLine('Input ->  ' + input);
            jsConsole.writeLine('Selection sorted -> ' + sorted);
            playWhat();
        }
    }
}

function problem_6() {
    input1.style.width = '400px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter numbers separated by comma ","';
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6. Most frequent number');
    jsConsole.writeLine(' - Write a script that finds the most frequent number in an array.');
    solutionText();

    submit.onclick = function () {

        var i = 0,
            mostFrequebtNumber,
            mostTimes = 1,
            tempTimes = 1,
            correctInput = true,
            input = input1.value.trim().split(',').map(Number),
            length = input.length,
            keepInput = [];

        for (i = 0; i < length; i += 1) {

            keepInput.push(input[i]);
            if (isNaN(input[i] * 1)) {
                correctInput = false;
            }
        }

        if (correctInput) {

            input = input.sort(sortNumber);

            for (i = 0; i < length - 1; i += 1) {


                if (input[i] === input[i + 1]) {
                    tempTimes += 1;
                } else {
                    tempTimes = 1;
                }

                if (tempTimes > mostTimes) {
                    mostTimes = tempTimes;
                    mostFrequebtNumber = input[i];
                }
            }

            printResult();
        }
        else {
            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('In array -> ' + keepInput);
            jsConsole.writeLine('Most frequent -> ' + mostFrequebtNumber + ' (' + mostTimes + ' times)');
            playWhat();
        }
    }
}

function problem_7() {
    playFinale();
    input1.style.width = '380px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter sorted numbers separated by comma ","';
    input2.style.width = '140px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Searched number';
    problemNumber.innerHTML = 'Problem 7';

    jsConsole.writeLine('Problem 7. Binary search');
    jsConsole.writeLine(' - Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.');
    solutionText();


    submit.onclick = function () {

        var index = 0,
            i = 0,
            key = input2.value * 1,
            correctInput = true,
            input = input1.value.trim().split(',').map(Number),
            length = input.length,
            sortedInput = true;

        for (i = 0; i < length; i += 1) {
            if (isNaN(key)) {
                correctInput = false;
                break;
            }
            if (isNaN(input[i] * 1)) {
                correctInput = false;
            }
        }

        if (correctInput) {

            for (i = 0; i < length - 1; i += 1) {
                if (input[i] > input[i + 1]) {
                    sortedInput = false;
                }
            }

            if (!sortedInput) {
                jsConsole.writeLine('Not sorted input!!  ( ' + input + ' )');
                input = input.sort(sortNumber);
                jsConsole.writeLine('Sorted for you => ' + input)
            } else {
                jsConsole.writeLine(input);
            }


            // recursive method


            index = binarySearch(input, key, 0, length - 1);

            function binarySearch(array, key, iMin, iMax) {

                if (iMin > iMax) {

                    return 'not found';
                } else {

                    var iMid = midpoint(iMin, iMax);
                    console.log('mid ' + iMid);

                    if (array[iMid] > key) {
                        return binarySearch(array, key, iMin, iMid - 1);
                    } else if (array[iMid] < key) {
                        return binarySearch(array, key, iMid + 1, iMax);
                    } else {
                        return iMid;
                    }
                }

                function midpoint(iMin, iMax) {
                    return iMin + (((iMax - iMin) / 2) | 0)
                }
            }

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('Searched: ' + key);
            jsConsole.writeLine('On index: ' + index);
            jsConsole.writeLine('');
            playEnding();
        }
    }
}

// to sort number arrays correctly(not alphabetically)
function sortNumber(a, b) {
    return a - b;
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

