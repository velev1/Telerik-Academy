/* -------------------------------------------------------------------------------------------------------------------*/
/* Scrips related to homework */


function problem_1() {
    input1.style.visibility = 'visible';
    input1.style.width = '150px';
    input1.placeholder = 'Enter [1...n]';
    problemNumber.innerHTML = 'Problem 1';

    jsConsole.writeLine('Problem 1. Numbers');
    jsConsole.writeLine(' - Write a script that prints all the numbers from 1 to N.');
    solutionText();

    submit.onclick = function () {
        var n = input1.value * 1,
            output = '';


        if (!isNaN(n) && (n % 1 === 0) && (n > 0)) {

            for (var i = 1; i <= n; i += 1) {
                output = output + ' ' + i;
            }
            jsConsole.writeLine(output);
            playWhat();


        } else {

            incorrectInput();
        }
    }
}

function problem_2() {
    playWorse();
    input1.style.visibility = 'visible';
    input1.style.width = '150px';
    input1.placeholder = 'Enter [1...n]';
    problemNumber.innerHTML = 'Problem 2';

    button_prev.disabled = false;

    jsConsole.writeLine('Problem 2. Numbers not divisible');
    jsConsole.writeLine(' - Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.');
    solutionText();

    submit.onclick = function () {
        var n = input1.value * 1,
            output = '';

        if (!isNaN(n) && (n % 1 === 0) && (n > 0)) {

            for (var i = 1; i <= n; i += 1) {
                if (i % 21 !== 0) {
                    output = output + ' ' + i;
                }
            }

            jsConsole.writeLine(output);
            playWhat();

        } else {

            incorrectInput();
        }
    }
}

function problem_3() {

    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter  numbers  separated  by  empty  space  "  "';
    input1.style.width = '500px';
    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Min/Max of sequence');
    jsConsole.writeLine(' Write a script that finds the max and min number from a sequence of numbers');
    solutionText();

    submit.onclick = function () {

        var input = input1.value,
            numbers = [],
            min = Number.MAX_VALUE,
            max = Number.MIN_VALUE;

        console.log(min);
        console.log(max);
        numbers = input.split(' '); // splits the input to array of strings
        console.log(numbers);
        numbers = removeEmptyEntries(numbers);

        // function to remove empty strings if the user adds more than one space
        function removeEmptyEntries(array) {
            var newArray = [];

            for (var i = 0, len = array.length; i < len; i += 1) {
                if (array[i])
                    newArray.push(array[i]);
            }

            console.log(newArray);
            return newArray;
        }

        findMinAndMax(numbers);

        function findMinAndMax(array) {
            for (var i = 0, len = numbers.length; i < len; i += 1) {
                if (min > (array[i] * 1)) {
                    min = array[i];
                }

                if (max < (array[i] * 1)) {
                    max = array[i];
                }
            }
        }

        printResult();

        function printResult() {
            jsConsole.writeLine('Min = ' + min + ', Max = ' + max);
            playWhat();
        }
    }
}

function problem_4() {
    playFinale();
    problemNumber.innerHTML = 'Problem 4';
    jsConsole.writeLine('Problem 4. Lexicographically smallest');
    jsConsole.writeLine(' - Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.');
    solutionText();
    jsConsole.writeLine(' - Click "SUBMIT INPUT" BUTTON TO SEE THE RESULT!!');
    jsConsole.writeLine('');
    jsConsole.writeLine('');

    submit.onclick = function () {

        findProperties(window);
        findProperties(document);
        findProperties(navigator);

        function findProperties(obj) {

            var properties = [],
                min,
                max;

            for (var property in obj) {
                properties.push(property);
            }

            properties = properties.sort();
            min = properties.shift();
            max = properties.pop();

            jsConsole.writeLine(obj);
            jsConsole.writeLine('smallest: ' + min);
            jsConsole.writeLine('largest : ' + max);
            jsConsole.writeLine('');
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
    audioAllow = confirm('Allow sound effects?');

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

    var skipper = test();

    skipper = setInterval(test, 1000);


    function test() {

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
        introStart1 = setTimeout(clickNext, 5100);


    donut.setAttribute('src', 'styles/media/donut.png');
    if (audioAllow) {
        musicButton();
        button_sounsFX.style.opacity = '1';
        button_sounsFX.style.backgroundImage = 'url("styles/media/sfx-button.gif")';
    }

    console.log('misic');

    introGif.style.display = 'inline-block';

    submit.onclick = skipIntro;

    function skipIntro() {
        if (!skipped) {
            clearTimeout(introStart1);
            clearTimeout(introStart1);
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
        setTimeout(audioMainMute, 1300);
        setTimeout(function () {audioDoh.play()}, 250);
    }
}

function playWhat() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 1300);
        setTimeout(function () {audioWhat.play()}, 250);
    }
}

function playWorse() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 3600);
        setTimeout(function () {audioWorse.play()}, 250);
    }
}

function playFinale() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 2800);
        setTimeout(function () {audioFinale.play()}, 250);
    }
}

function playEnding() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 4600);
        setTimeout(function () {audioEnding.play()}, 250);
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
    if (problemCounter > 3) {
        button_next.disabled = true;
    }
    problemSwitch();
};

button_prev.onclick = function () {
    problemCounter -= 1;
    button_next.disabled = false;
    if (problemCounter < 2) {
        button_prev.disabled = true;
    }
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
            problem_1();
            break;
        case 2:
            problem_2();
            break;
        case 3:
            problem_3();
            break;
        case 4:
            problem_4();
            break;
    }
}
