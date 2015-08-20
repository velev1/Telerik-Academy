var button_next = document.getElementById('next'),
    button_prev = document.getElementById('prev'),
    button_music = document.getElementById('music'),
    button_soundsFX = document.getElementById('sfx'),
    buttons_all = document.getElementsByTagName('button'),
    check_box = document.getElementById('check'),
    check_label = document.getElementById('check-label'),
    problemCounter = 0,
    homer = document.getElementById('backgroundWrapper'),

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
    dontPush = document.createElement('audio'),
    audioOverButton = document.createElement('audio'),
    introGif = document.getElementById('intro'),
    board = document.getElementById('board'),
    vinyl = document.getElementById('vinyl'),
    paused = true,
    winHeight = window.screen.availHeight,
    winWidth = window.screen.availWidth,
    skipped = false,
    dontButtonPushed = false,
    mainAudioMuted = false,
    playDotPush,
    audioAllow = confirm('Sound effects ON?' +
        '\n\r You can ON/OFF later :)');

scalePage();
initialiseSounds();
introTimer();

button_next.onmouseover = overButton;
button_prev.onmouseover = overButton;
button_music.onmouseover = overButton;
button_soundsFX.onmouseover = overButton;
check_label.onmouseover = overButton;
check_box.onmouseover = overButton;
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
            skipped = true;
            submit.onmouseover = overButton;
        }
    }

    var introStart1 = setTimeout(afterIntro, skipCounter * 1000 + 1100),
        introStart2 = setTimeout(button_next.click(), skipCounter * 1000 + 1100);


    vinyl.setAttribute('src', vinylPlay);

    if (audioAllow) {
        musicButton();
        button_soundsFX.style.opacity = '1';
        button_soundsFX.style.backgroundImage = sfxON;
    }

    introGif.style.display = 'inline-block';

    submit.onclick = skipIntro;

    submit.onmouseover = playDotPush;

    function skipIntro() {
        dontButtonPushed = true;
        if (!skipped) {

            clearTimeout(introStart1);
            clearTimeout(introStart2);
            afterIntro();
            button_next.click();
            skipped = true;
        }
    }
}

function scalePage() {
    var zoom = ((winHeight - 120 ) / 820) * 1;
    console.log('zoom ' + zoom);
    console.log('width ' + winWidth);
    console.log('height ' + winHeight);

    if (zoom > 1) {
        homer.style.width = winWidth / (zoom * 1.1);
        console.log('greater than 1')
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

function audioMainMute() {
    if (mainAudioMuted) {
        audioMain.volume = 0.4;
        mainAudioMuted = false;
    } else {
        audioMain.volume = 0.1;
        mainAudioMuted = true;
    }
}

button_music.onclick = musicButton;
button_soundsFX.onclick = soundFX;


function soundFX() {
    if (audioAllow) {
        audioAllow = false;
        button_soundsFX.style.opacity = '0.5';
        button_soundsFX.style.backgroundImage = sfxOFF;
    } else {
        audioAllow = true;
        button_soundsFX.style.opacity = '1';
        button_soundsFX.style.backgroundImage = sfxON;
        button_next.onmouseover = overButton;
        button_prev.onmouseover = overButton;
        button_music.onmouseover = overButton;
        button_soundsFX.onmouseover = overButton;
    }
}

function overButton() {
    if (audioAllow) {
        audioOverButton.play();
    }

}
function musicButton() {
    console.log('clicked');
    if (paused) {
        audioMain.play();
        button_music.style.backgroundImage = musicPause;
        vinyl.setAttribute('src', vinylPlay);
        paused = false;
    }
    else {
        audioMain.pause();
        button_music.style.backgroundImage = musicPlay;
        vinyl.setAttribute('src', vinylPause);
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
    jsConsole.writeLine(wrongInputMessage);
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
    check_box.style.visibility = 'hidden';
    check_label.style.visibility = 'hidden';
    check_label.style.width = '0px';
    check_label.innerHTML = '';
}
