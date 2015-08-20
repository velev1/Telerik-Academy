/* -------------------------------------------------------------------------------------------------------------------*/
/* Scrips related to homework */

function problem_1() {

    problemNumber.innerHTML = 'Problem 1';
    input1.style.visibility = 'visible';
    input1.style.width = '200px';
    input1.placeholder = 'Enter "number"';

    jsConsole.writeLine('Problem 1. Odd or Even');
    jsConsole.writeLine(' - Write an expression that checks if given integer is odd or even.');
    solutionText();

    submit.onclick = function () {
        var num = input1.value * 1;

        if (!isNaN(num)) {

            var result;
            if (num % 2 === 0) {
                result = 'Even';
            } else {
                result = 'Odd';
            }
            printResult();
        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(num + ' is ' + result);
            playWhat();
        }
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.visibility = 'visible';
    input1.style.width = '200px';
    input1.placeholder = 'Enter "number"';

    jsConsole.writeLine('Problem 2. Divisible by 7 and 5');
    jsConsole.writeLine(' - Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.');
    solutionText();
    submit.onclick = function () {

        var num = input1.value * 1;

        if (!isNaN(num)) {

            var result = false;
            if (num % 7 === 0 && num % 5 === 0) {
                result = true;
            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(num + ' Divided by 7 and 5? -> ' + result);
            playWhat();
        }
    }
}

function problem_3() {
    problemNumber.innerHTML = 'Problem 3';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter "width"';
    input1.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter "height"';
    input2.style.width = '200px';

    jsConsole.writeLine('Problem 3. Rectangle area');
    jsConsole.writeLine(' - Write an expression that calculates rectangle’s area by given width and height.');
    solutionText();
    submit.onclick = function () {

        var width = input1.value * 1;
        var height = input2.value * 1;


        if (!isNaN(width) && !isNaN(height)) {

            if (width < 0 || height < 0) {
                incorrectInput();
                return;

            }

            var result = width * height;
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('Rectangle  area with width = ' + width + ' ang height = ' + height + ' has area of ' + result + ' square units');
            playWhat();
        }
    }
}

function problem_4() {
    problemNumber.innerHTML = 'Problem 4';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter integer';
    input1.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter position';
    input2.style.width = '170px';
    input2.value = 3;
    input3.style.visibility = 'visible';
    input3.style.width = '200px';
    input3.placeholder = 'Number to check';
    input3.value = 7;

    jsConsole.writeLine('Problem 4. Third digit');
    jsConsole.writeLine(' - Write an expression that checks for given integer if its third digit (right-to-left) is 7.');
    jsConsole.writeLine(' - PS - you can change the position and searched number on the position');
    solutionText();
    submit.onclick = function () {

        var number = input1.value * 1,
            keepNumber = number,
            position = input2.value * 1,
            toCheck = input3.value * 1,
            result = false;

        if (!isNaN(number) && !isNaN(position) && !isNaN(toCheck)) {
            for (var i = 1; i < position; i += 1) {
                number /= 10;
                number |= 0; // make the number integer because by default it i float number and the algorithm does not work
                console.log(number);
            }

            if (number % 10 === toCheck) {
                result = true;
                console.log(result);
            }
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(keepNumber + ' -> ' + position + ' digit ' + toCheck + ' ? -> ' + result);
            playWhat();
        }
    }
}


function problem_5() {
    playWorse();
    problemNumber.innerHTML = 'Problem 5';
    input1.style.visibility = 'visible';
    input1.style.width = '200px';
    input1.placeholder = 'Enter integer';

    jsConsole.writeLine('Problem 5. Third bit');
    jsConsole.writeLine(' - Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.');
    jsConsole.writeLine(' - The bits are counted from right to left, starting from bit #0.');
    jsConsole.writeLine(' - The result of the expression should be either 1 or 0');
    solutionText();

    submit.onclick = function () {

        var number = input1.value * 1,
            result,
            binary;

        if (!isNaN(number)) {

            number |= 0; // to be sure that the number is integer because the  !isNaN check does not take that difference

            binary = number.toString(2);

            result = (number >> 3) & 1; // shift 3-rd digit to most right and logical and(&) with 1 (if 3 digit is 1 1&1 = 1, all other are 0 or 1 & 0 -> so 0)
            console.log(result);

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine(number + ' - "' + binary + '" digit #3 (starting from bit #0) -> ' + '"' + result + '"');
            playWhat();
        }
    }
}

function problem_6() {

    problemNumber.innerHTML = 'Problem 6';
    input1.style.visibility = 'visible';
    input1.style.width = '200px';
    input1.placeholder = 'Enter x';
    input2.style.visibility = 'visible';
    input2.style.width = '200px';
    input2.placeholder = 'Enter y';

    jsConsole.writeLine('Problem 6. Point in Circle');
    jsConsole.writeLine(' - Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius');
    solutionText();

    submit.onclick = function () {

        var x = input1.value * 1,
            y = input2.value * 1,
            radius = 5,
            result = false;

        if (!isNaN(x) && !isNaN(y)) {

            if (Math.sqrt((x * x) + (y * y)) <= radius)

                result = true;
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('P(' + x + ', ' + y + ') is in circle? -> ' + result);
            playWhat();
        }
    }
}

function problem_7() {
    problemNumber.innerHTML = 'Problem 7';
    input1.style.visibility = 'visible';
    input1.style.width = '250px';
    input1.placeholder = 'n (n <= 100)';

    jsConsole.writeLine('Problem 7. Is prime');
    jsConsole.writeLine(' - Write an expression that checks if given positive integer number n (n &le; 100) is prime.');
    solutionText();


    submit.onclick = function () {

        var number = input1.value * 1,
            result = true;

        if (!isNaN(number) && number > 1) {

            number |= 0; // to be sure that the number is integer because the  !isNaN check does not take that difference

            for (var n = 2, l = Math.sqrt(number); n <= l; n += 1) {
                if (number % n === 0) {
                    result = false;
                    break;
                }
            }

            printResult();

        } else {

            result = false;
            printResult();
        }

        function printResult() {
            jsConsole.writeLine(number + ' is Prime number? -> ' + result);
            playWhat();
        }
    }
}


function problem_8() {
    problemNumber.innerHTML = 'Problem 8';
    input1.style.visibility = 'visible';
    input1.style.width = '150px';
    input1.placeholder = 'a';
    input2.style.visibility = 'visible';
    input2.style.width = '150px';
    input2.placeholder = 'b';
    input3.style.visibility = 'visible';
    input3.style.width = '150px';
    input3.placeholder = 'h';

    jsConsole.writeLine('Problem 8. Trapezoid area');
    jsConsole.writeLine(" - Write an expression that calculates trapezoid's area by given sides a and b and height h.");
    solutionText();

    submit.onclick = function () {

        var a = input1.value * 1,
            b = input2.value * 1,
            h = input3.value * 1,
            area;

        if (!isNaN(a) && !isNaN(b) && !isNaN(h)) {
            area = ((a + b) / 2) * h;
            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('Trapezoid with a = ' + a + ', b = ' + b + ', h = ' + h + ' -> Area = ' + area + ' square units');
            playWhat();
        }
    }
}


function problem_9() {
    playFinale();
    problemNumber.innerHTML = 'Problem 8';
    input1.style.visibility = 'visible';
    input1.style.width = '200px';
    input1.placeholder = 'Enter x';
    input2.style.visibility = 'visible';
    input2.style.width = '200px';
    input2.placeholder = 'Enter y';

    jsConsole.writeLine('Problem 9. Point in Circle and outside Rectangle');
    jsConsole.writeLine(' - Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).');
    solutionText();

    submit.onclick = function () {

        var x = input1.value * 1,
            y = input2.value * 1,
            radius = 3,
            result = 'yes';

        if (!isNaN(x) && !isNaN(y)) {

            // check is outside of circle
            if (Math.pow(x - 1, 2) + Math.pow(y - 1, 2) > Math.pow(radius, 2)) {

                result = 'no';
            }
            // check is in rectangle
            if ((x <= 5 && x >= -1) && (y >= -1 && y <= 1)) {
                result = 'no';
            }

            printResult();

        } else {

            incorrectInput();
        }

        function printResult() {
            jsConsole.writeLine('P(' + x + ', ' + y + ') is in circle and outside rectangle? -> ' + result);
            playEnding();
        }
    }
}

/* -------------------------------------------------------------------------------------------------------------------*/
/* Scripts related to fun part */

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
        '\n\r You can ON/OFF later :)');

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
        introStart1 = setTimeout(button_next.click(), 5100);


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
            clearTimeout(introStart1);
            afterIntro();
            button_next.click();
            skipped = true;
        }
    }
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

function audioMainMute() {
    if (mainAudioMuted) {
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
        setTimeout(function () {
            audioDoh.play()
        }, 150);
    }
}

function playWhat() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 1200);
        setTimeout(function () {
            audioWhat.play()
        }, 150);
    }
}

function playWorse() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 3500);
        setTimeout(function () {
            audioWorse.play()
        }, 150);
    }
}

function playFinale() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 2700);
        setTimeout(function () {
            audioFinale.play()
        }, 150);
    }
}

function playEnding() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 4500);
        setTimeout(function () {
            audioEnding.play()
        }, 150);
    }
}

button_music.onclick = musicButton;
button_sounsFX.onclick = soundFX;

function soundFX() {
    if (audioAllow) {
        audioAllow = false;
        button_sounsFX.style.opacity = '0.5';
        button_sounsFX.style.backgroundImage = 'url("styles/media/sfx-button.png")';
    } else {
        audioAllow = true;
        button_sounsFX.style.opacity = '1';
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
            problem_7();
            break;
        case 8:
            button_next.disabled = false;
            problem_8();
            break;
        case 9:
            button_next.disabled = true;
            problem_9();
            break;
    }
}
