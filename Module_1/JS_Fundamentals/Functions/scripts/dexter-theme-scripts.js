var vinylPause = '../styles/media/dexter/vinyl.png',
    vinylPlay = '../styles/media/dexter/vinyl.gif',
    sfxON = 'url("../styles/media/sfx-button.gif")',
    sfxOFF = 'url("../styles/media/sfx-button.png")',
    musicPause = 'url("../styles/media/pause-button.png")',
    musicPlay = 'url("../styles/media/play-button.png")',
    wrongInputMessage = 'No no no no no, that would never work!',
    audioBoom = document.createElement('audio'),
    skipCounter = 16;


function initialiseSounds() {
    audioMain.setAttribute('src', '../styles/media/dexter/main-theme.mp3');
    audioMain.setAttribute('id', 'main-theme');
    audioMain.loop = true;
    audioMain.volume = 0.4;

    audioDoh.setAttribute('src', '../styles/media/dexter/doh.mp3');
    audioDoh.setAttribute('id', 'doh');

    audioWhat.setAttribute('src', '../styles/media/dexter/whatever.mp3');
    audioWhat.setAttribute('id', 'whatever');

    audioEnding.setAttribute('src', '../styles/media/dexter/ending.mp3');
    audioEnding.setAttribute('id', 'ending');

    audioFinale.setAttribute('src', '../styles/media/dexter/finale.mp3');
    audioFinale.setAttribute('id', 'finale');

    audioWorse.setAttribute('src', '../styles/media/dexter/worse.mp3');
    audioWorse.setAttribute('id', 'worse');

    dontPush.setAttribute('src', '../styles/media/dexter/dont-push.mp3');
    dontPush.setAttribute('id', 'dont-push');

    audioOverButton.setAttribute('src', '../styles/media/dexter/button-over.mp3');
    audioOverButton.setAttribute('id', 'button-over-push');
    audioOverButton.volume = 0.2;

    audioBoom.setAttribute('src', '../styles/media/dexter/boom.mp3');
    audioBoom.setAttribute('id', 'boom');

}

function playBoom() {
    if (audioAllow) {
        audioMainMute();
        setTimeout(audioMainMute, 9200);
        setTimeout(function () {
            audioBoom.play()
        }, 150);
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

function playDotPush() {
    if (!dontButtonPushed) {

        dontButtonPushed = true;

        // var temAudioAllow = audioAllow;

        if (audioAllow) {
            submit.style.background = 'red';
            audioMainMute();
            setTimeout(audioMainMute, 10150);
            setTimeout(function () {
                dontPush.play();
                setTimeout(function () {
                    var isBoom = confirm('Push the button anyway?');
                    if (isBoom) {
                        boom();
                    } else {
                        alert("You've just saved the world \n\r and missed the fun... :)");
                        submit.style.background = '#5b5b5b';
                        submit.onmouseover = overButton;
                    }
                }, 10000)
            }, 150);
        }
    }
}

function boom() {
    var hide,
        show;
    
    playBoom();

    setTimeout(blinkScreen, 1200);

    function blinkScreen() {
        hide = setInterval(function () {
            document.body.style.opacity = '0.1';

            show = setTimeout(function () {
                document.body.style.opacity = '1';
            }, 50);

        }, 100);

        setTimeout(function () {
            clearInterval(hide);
            submit.style.background = '#5b5b5b';
            alert("You've just blown up the world!! :)");
            submit.onmouseover = overButton;

        }, 5000);
    }
}