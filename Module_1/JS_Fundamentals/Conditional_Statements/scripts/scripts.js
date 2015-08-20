/* -------------------------------------------------------------------------------------------------------------------*/
/* Scrips related to homework */


function problem_1() {
    problemNumber.innerHTML = 'Problem 1';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "a"';
    input2.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "b"';

    jsConsole.writeLine('Problem 1. Exchange if greater');
    jsConsole.writeLine(' - Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.');
    jsConsole.writeLine(' - As a result print the values a and b, separated by a space.');
    solutionText();


    submit.onclick = function () {
        var a = input1.value * 1,
            b = input2.value * 1;

        if (!isNaN(a) && !isNaN(b)) {

            if (a > b) {
                var temp = b;
                b = a;
                a = temp;
            }

            printResult();


        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(a + ' ' + b);
            playWhat();
        }
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '170px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "a"';
    input2.style.width = '170px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "b"';
    input3.style.width = '170px';
    input3.style.visibility = 'visible';
    input3.placeholder = 'Enter "c"';


    jsConsole.writeLine('Problem 2. Multiplication Sign');
    jsConsole.writeLine(' - Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.');
    jsConsole.writeLine(' - Use a sequence of if operators.');
    solutionText();
    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            c = input3.value * 1,
            negativeCounter = 0,
            result = '+';

        if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {

            if (a === 0 || b === 0 || c === 0) {
                result = 0;
            } else if (a < 0 || b < 0 || c < 0) {
                if (a < 0) {
                    negativeCounter += 1;
                }
                if (b < 0) {
                    negativeCounter += 1;
                }
                if (c < 0) {
                    negativeCounter += 1;
                }
                if (negativeCounter % 2 == 1) {
                    result = '-';
                }
            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('a = ' + a + ', b = ' + b + ', c = ' + c + ';&nbsp;&nbsp;&nbsp;&nbsp;result = ' + result);
            playWhat();
        }
    }
}

function problem_3() {
    input1.style.width = '170px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "a"';
    input2.style.width = '170px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "b"';
    input3.style.width = '170px';
    input3.style.visibility = 'visible';
    input3.placeholder = 'Enter "c"';
    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. The biggest of Three');
    jsConsole.writeLine(' - Write a script that finds the biggest of three numbers.');
    jsConsole.writeLine(' - Use nested if statements.');
    solutionText();
    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            c = input3.value * 1,
            biggest = a;


        if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {

            if (b > biggest) {
                biggest = b;
            }
            if (c > biggest) {
                biggest = c;
            }

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('a = ' + a + ', b = ' + b + ', c = ' + c + ';&nbsp;&nbsp;&nbsp;&nbsp;biggest = ' + biggest);
            playWhat();
        }
    }
}

function problem_4() {
    input1.style.width = '170px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "a"';
    input2.style.width = '170px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "b"';
    input3.style.width = '170px';
    input3.style.visibility = 'visible';
    input3.placeholder = 'Enter "c"';
    problemNumber.innerHTML = 'Problem 4';

    jsConsole.writeLine('Problem 4. Sort 3 numbers');
    jsConsole.writeLine(' - Sort 3 real values in descending order.');
    jsConsole.writeLine(' - Use nested if statements.');
    solutionText();
    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            c = input3.value * 1,
            sortedAsString;

        if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
            if (a >= b) {
                if (c >= a) {
                    sortedAsString = c + ' ' + a + ' ' + ' ' + b;
                    console.log(a);
                    console.log(b);
                    console.log(c);
                } else if (c <= b) {
                    sortedAsString = a + ' ' + b + ' ' + c;
                } else if (c > b) {
                    sortedAsString = a + ' ' + c + ' ' + b;
                }
            } else if (b > a) {
                if (c >= b) {
                    sortedAsString = c + ' ' + b + ' ' + a;
                } else if (c <= a) {
                    sortedAsString = b + ' ' + a + ' ' + c;
                } else if (c > a) {
                    sortedAsString = b + ' ' + c + ' ' + a;
                }
            }

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('a = ' + a + ', b = ' + b + ', c = ' + c + ';&nbsp;&nbsp;&nbsp;&nbsp;sorted: ' + sortedAsString);
            playWhat();
        }
    }
}

function problem_5() {
    playWorse();
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter digit (0-9)';
    problemNumber.innerHTML = 'Problem 5';

    jsConsole.writeLine('Problem 5. Digit as word');
    jsConsole.writeLine(' - Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).');
    jsConsole.writeLine(' - Print “not a digit” in case of invalid input.');
    jsConsole.writeLine(' - Use a switch statement.');
    solutionText();


    submit.onclick = function () {

        var digit = input1.value,
            result;

        switch (digit) {
            case '0':
                result = 'zero';
                break;
            case '1':
                result = 'one';
                break;
            case '2':
                result = 'two';
                break;
            case '3':
                result = 'three';
                break;
            case '4':
                result = 'four';
                break;
            case '5':
                result = 'five';
                break;
            case '6':
                result = 'six';
                break;
            case '7':
                result = 'seven';
                break;
            case '8':
                result = 'eight';
                break;
            case '9':
                result = 'nine';
                break;
            default :
                result = 'not a digit';
                playDoh();
                break;
        }

        printResult();

        function printResult() {
            jsConsole.writeLine(digit + ' ->  ' + result);
            if (result !== 'not a digit') {
                playWhat();
            }
        }
    }
}

function problem_6() {
    input1.style.width = '170px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "a"';
    input2.style.width = '170px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "b"';
    input3.style.width = '170px';
    input3.style.visibility = 'visible';
    input3.placeholder = 'Enter "c"';
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6. Quadratic equation');
    jsConsole.writeLine(' - Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).');
    jsConsole.writeLine(' - Calculates and prints its real roots.');
    solutionText();
    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            c = input3.value * 1,
            d,
            x1,
            x2,
            equation = a + 'x<sup>2</sup> + ' + b + 'x + ' + c + ' = 0;&nbsp;&nbsp;&nbsp;&nbsp;-> &nbsp;&nbsp;',
            resultMessage;

        if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {

            if (a === 0) {
                resultMessage = 'is not quadratic equation!!'

                printResult(resultMessage);
            } else {
                d = (b * b) - (4 * a * c);

                if (d < 0) {
                    resultMessage = 'no real roots'
                    printResult(resultMessage);
                } else if (d === 0) {
                    x1 = x2 = (-b) / (2 * a);
                    resultMessage = 'x<sub>1</sub> = x<sub>2</sub> = ' + x1;
                    printResult(resultMessage);
                } else {
                    x1 = ((-b) - Math.sqrt(d)) / (2 * a);
                    x2 = ((-b) + Math.sqrt(d)) / (2 * a);
                    resultMessage = 'x<sub>1</sub> = ' + x1 + '; x<sub>2</sub> = ' + x2;
                    printResult(resultMessage);
                }
            }

        } else {

            incorrectInput();
        }

        function printResult(resultMessage) {
            jsConsole.writeLine(equation + resultMessage);
            playWhat();
        }
    }
}

function problem_7() {
    input1.style.width = '100px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'a';
    input2.style.width = '100px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'b';
    input3.style.width = '100px';
    input3.style.visibility = 'visible';
    input3.placeholder = 'c';
    input4.style.width = '100px';
    input4.style.visibility = 'visible';
    input4.placeholder = 'd';
    input5.style.width = '100px';
    input5.style.visibility = 'visible';
    input5.placeholder = 'e';
    problemNumber.innerHTML = 'Problem 7';

    jsConsole.writeLine('Problem 7. The biggest of five numbers');
    jsConsole.writeLine(' - Write a script that finds the greatest of given 5 variables.');
    jsConsole.writeLine(' - Use nested if statements.');
    solutionText();


    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            c = input3.value * 1,
            d = input4.value * 1,
            e = input5.value * 1,
            biggest = a;

        if (!isNaN(a) && !isNaN(b) && !isNaN(c) && !isNaN(d) && !isNaN(e)) {

            if (b > biggest) {
                biggest = b;
            }
            if (c > biggest) {
                biggest = c;
            }
            if (d > biggest) {
                biggest = d;
            }
            if (e > biggest) {
                biggest = e;
            }

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('a = ' + a + ', b = ' + b + ', c = ' + c + ', d = ' + d + ', e = ' + e + ';&nbsp;&nbsp;&nbsp;&nbsp;biggest = ' + biggest);
            playWhat();
        }
    }
}

function problem_8() {

    playFinale();
    input1.style.width = '100px';
    input1.style.visibility = 'visible';
    input1.placeholder = '[0...999]';
    problemNumber.innerHTML = 'Problem 8';

    jsConsole.writeLine('Problem 8. Number as words');
    jsConsole.writeLine(" - Write a script that converts a number in the range [0...999] to words, corresponding to its English pronunciation.");
    solutionText();

    submit.onclick = function () {

        var number = input1.value * 1,
            keepNumber = number,
            numberAsWord = '',
            ones = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven',
                'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
            tents = ['twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'],
            temp;

        if (!isNaN(number) && (number % 1 === 0)) {
            temp = (number / 100) | 0;
            console.log(temp);
            if (temp > 0) {
                console.log(temp);
                numberAsWord = ones[temp] + ' hundred ';

                if (number % 100 !== 0) {
                    numberAsWord = numberAsWord + ' and '
                    number = number - (temp * 100);
                } else {
                    printResult();
                    return;
                }
            }

            temp = (number / 10) | 0;

            if (temp > 1) {

                numberAsWord = numberAsWord + tents[temp - 2] + ' ';

                if (number % 10 === 0) {
                    printResult();
                    return;
                }
                number = number - (temp * 10);
            }

            if (number < 20) {
                numberAsWord = numberAsWord + ones[number];
            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(keepNumber + ' -> ' + numberAsWord);
            playEnding();
        }
    }
}

/* -------------------------------------------------------------------------------------------------------------------*/
/* Scripts related to fun part*/

var button_next = document.getElementById('next'),
    button_prev = document.getElementById('prev'),
    button_music = document.getElementById('music'),
    button_sounsFX = document.getElementById('sfx'),
    problemCounter = 0,
    homer = document.getElementById('homer'),

    submit = document.getElementById('submit'),

    input1 = document.getElementById('input1'),
    input2 = document.getElementById('input2'),
    input3 = document.getElementById('input3'),
    input4 = document.getElementById('input4'),
    input5 = document.getElementById('input5'),

    problemNumber = document.getElementById('problem'),

    audioDoh = document.createElement('audio'),
    audioWhat = document.createElement('audio'),
    audioWorse = document.createElement('audio'),
    audioFinale = document.createElement('audio'),
    audioEnding = document.createElement('audio'),
    audioMain = document.createElement('audio'),
    introGif = document.getElementById('intro'),
    board = document.getElementById('board'),
    donut = document.getElementById('donut'),
    paused = true,
    winHeight = window.screen.availHeight,
    winWidth = window.screen.availWidth,
    skipCounter = 5,
    skipped = false,
    mainAudioMuted = false,
    audioAllow = confirm('Sound effects ON?' +
        '\n\r You can ON/OFF later :)' );

scalePage();
initialiseSounds();
introTimer();


function afterIntro() {
    introGif.style.display = 'none';
    board.style.visibility = 'visible';
    button_next.disabled = false;
    submit.innerHTML = 'SUBMIT INPUT';
}


function introTimer() {

    console.log(skipCounter);

    var skipper = skip();

    skipper = setInterval(skip, 1000);


    function skip() {

        submit.innerHTML = 'SKIP &nbsp;&nbsp; ' + skipCounter;
        console.log(skipCounter);

        if (skipCounter > 0 && skipped === false) {
            skipCounter = skipCounter - 1;
        } else {
            clearInterval(skipper);
            submit.innerHTML = 'SUBMIT INPUT';
            skipIntro();
        }
    }

    var introStart1 = setTimeout(afterIntro, 5100),
        introStart2 = setTimeout(clickNext, 5100);


    donut.setAttribute('src', 'styles/media/donut.png');
    if (audioAllow) {
        musicButton();
        button_sounsFX.style.opacity = '1';
        button_sounsFX.style.backgroundImage = 'url("styles/media/sfx-button.gif")';
    }

    introGif.style.display = 'inline-block';

    submit.onclick = skipIntro;

    function skipIntro() {
        if (!skipped) {
            clearTimeout(introStart1);
            clearTimeout(introStart2);
            afterIntro();
            clickNext();
            skipped = true;
        }
    }
}

function clickNext() {
    button_next.click();
}


function scalePage() {
    var zoom = (((winHeight - 120 ) / 820) ) * 1;

    if (zoom > 1) {
        homer.style.width = winWidth / (zoom * 1.1);
    } else {
        homer.style.width = winWidth / 1.1;
    }


    homer.style.transform = 'scale(' + zoom + ',' + zoom + ')';
    homer.style['transform-origin'] = 50 + '% ' + 0 + '% ' + 0;

    homer.style['-o-transform'] = 'scale(' + zoom + ',' + zoom + ')';
    homer.style['-o-transform-origin'] = 50 + '% ' + 0 + '% ' + 0 + '%';

    homer.style['-webkit-transform'] = 'scale(' + zoom + ',' + zoom + ')';
    homer.style['-webkit-transform-origin'] = 50 + '% ' + 0 + '% ' + 0 + '%';

    homer.style['-ms-transform'] = 'scale(' + zoom + ',' + zoom + ')';
    homer.style['-ms-transform-origin'] = 50 + '% ' + 0 + '% ' + 0 + '%';

    homer.style['-moz-transform'] = 'scale(' + zoom + ',' + zoom + ')';
    homer.style['-moz-transform-origin'] = 50 + '% ' + 0 + '% ' + 0 + '%';
}


function initialiseSounds() {
    audioMain.setAttribute('src', 'styles/media/main-theme.mp3');
    audioMain.setAttribute('id', 'main-theme');
    audioMain.loop = true;
    audioMain.volume = 0.4;

    audioDoh.setAttribute('src', 'styles/media/doh.mp3');
    audioDoh.setAttribute('id', 'doh');

    audioWhat.setAttribute('src', 'styles/media/whatever.mp3');
    audioWhat.setAttribute('id', 'whatever');

    audioEnding.setAttribute('src', 'styles/media/ending.mp3');
    audioEnding.setAttribute('id', 'ending');

    audioFinale.setAttribute('src', 'styles/media/finale.mp3');
    audioFinale.setAttribute('id', 'finale');

    audioWorse.setAttribute('src', 'styles/media/worse.mp3');
    audioWorse.setAttribute('id', 'worse');
}

function audioMainMute(){
    if(mainAudioMuted){
        audioMain.volume = 0.5;
        mainAudioMuted = false;
    } else {
        audioMain.volume = 0.1;
        mainAudioMuted = true;
    }
}

function playDoh() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 1200);
        setTimeout(function () {audioDoh.play()}, 150);
    }
}

function playWhat() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 1200);
        setTimeout(function () {audioWhat.play()}, 150);
    }
}

function playWorse() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 3500);
        setTimeout(function () {audioWorse.play()}, 150);
    }
}

function playFinale() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 2700);
        setTimeout(function () {audioFinale.play()}, 150);
    }
}

function playEnding() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 4500);
        setTimeout(function () {audioEnding.play()}, 150);
    }
}

button_music.onclick = musicButton;
button_sounsFX.onclick = soundFX;

function soundFX() {
    if(audioAllow){
        audioAllow = false;
        button_sounsFX.style.opacity = '0.5';
        button_sounsFX.style.backgroundImage = 'url("styles/media/sfx-button.png")';
    }else{
        audioAllow = true;
        button_sounsFX.style.opacity =  '1';
        button_sounsFX.style.backgroundImage = 'url("styles/media/sfx-button.gif")';
    }
}
function musicButton() {
    console.log('clicked');
    if (paused) {
        audioMain.play();
        button_music.style.backgroundImage = 'url("styles/media/pause-button.png")';
        donut.setAttribute('src', 'styles/media/donut.gif');
        paused = false;
    }
    else {
        audioMain.pause();
        button_music.style.backgroundImage = 'url("styles/media/play-button.png")';
        donut.setAttribute('src', 'styles/media/donut.png');
        paused = true;
    }
}

button_next.onclick = function () {
    problemCounter += 1;
    problemSwitch();
};

button_prev.onclick = function () {
    problemCounter -= 1;
    problemSwitch();
};

function incorrectInput() {
    jsConsole.writeLine('Doh! wrong input :)');
    playDoh();

}

function solutionText() {
    jsConsole.writeLine('');
    jsConsole.writeLine('&nbsp;&nbsp;&nbsp;---------------------------------------------------------------------------------');
    jsConsole.writeLine('');
    jsConsole.writeLine('Result: ');
    jsConsole.writeLine('');
}

function resetInputFields() {
    input1.style.visibility = 'hidden';
    input1.value = '';
    input1.style.width = '0px';
    input2.style.visibility = 'hidden';
    input2.value = '';
    input2.style.width = '0px';
    input3.style.visibility = 'hidden';
    input3.value = '';
    input3.style.width = '0px';
    input4.style.visibility = 'hidden';
    input4.value = '';
    input4.style.width = '0px';
    input5.style.visibility = 'hidden';
    input5.value = '';
    input5.style.width = '0px';
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
            problem_6();
            break;
        case 7:
            button_next.disabled = false;
            problem_7();
            break;
        case 8:
            button_next.disabled = true;
            problem_8();
            break;
    }
}

