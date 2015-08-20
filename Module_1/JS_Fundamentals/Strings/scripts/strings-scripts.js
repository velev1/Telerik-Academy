function problem_1() {
    problemNumber.innerHTML = 'Problem 1';
    input1.style.width = '300px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some string';

    jsConsole.writeLine('Problem 1. Reverse string');
    jsConsole.writeLine(' - WWrite a JavaScript function that reverses a string and returns it.');
    solutionText();

    submit.onclick = function () {
        var input = input1.value,
            reversed;

        reversed = reverseString(input);

        // It looks like all around fast way - http://eddmann.com/posts/ten-ways-to-reverse-a-string-in-javascript/
        function reverseString(str) {
            var reversed = '';
            for (var i = str.length - 1; i >= 0; i -= 1) {
                reversed += str[i];
            }

            return reversed;
        }

        printResult(input, reversed);

        function printResult(input, reversed) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Input: ' + input);
            jsConsole.writeLine('Reversed: ' + reversed);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some string with brackets ( )';

    jsConsole.writeLine('Problem 2. Correct brackets');
    jsConsole.writeLine(' - Write a JavaScript function to check if in a given expression the brackets are put correctly.');
    jsConsole.writeLine(' - Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).');
    solutionText();

    submit.onclick = function () {

        var input = input1.value,
            correctBrackets;

        correctBrackets = checkBrackets(input);

        printResult(input, correctBrackets);

        function checkBrackets(str) {
            var leftBrackets = 0,
                rightBrackets = 0,
                i,
                len;

            for (i = 0, len = str.length; i < len; i += 1) {
                if (str[i] === '(') {
                    leftBrackets += 1;
                }
                if (str[i] === ')') {
                    rightBrackets += 1;
                }
                if (rightBrackets > leftBrackets) {
                    return false;
                }
                if (i === len - 1 && leftBrackets !== rightBrackets) {
                    return false;
                }
            }
            return true;
        }

        function printResult(input, correctBrackets) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Input: ' + input);
            jsConsole.writeLine('Correct brackets: ' + correctBrackets);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_3() {
    input1.style.width = '250px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text';
    input1.value = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
    input2.style.width = '160px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Searched sub string';
    input2.value = 'in';

    problemNumber.innerHTML = 'Problem 3';

    jsConsole.writeLine('Problem 3. Sub-string in text');
    jsConsole.writeLine(' - Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).');
    solutionText();

    submit.onclick = function () {
        var text = input1.value,
            searched = input2.value,
            occurrence;

        // Calling the function that makes magic and returns the count of the searched word
        occurrence = occurrenceInText(text, searched);

        // This is the function that makes the magic
        function occurrenceInText(text, searched) {
            var occurrence = 0,
                index = -1;

            searched = searched.toLowerCase();
            text = text.toLowerCase();

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

        printResult(text, searched, occurrence);

        function printResult(text, searched, occurrence) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In text: ' + text);
            jsConsole.writeLine('');
            jsConsole.writeLine('"' + searched + '" occurs "' + occurrence + '" times!');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_4() {
    problemNumber.innerHTML = 'Problem 4';
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter text';
    input1.value = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

    jsConsole.writeLine('Problem 4. Parse tags');
    jsConsole.writeLine(' - You are given a text. Write a function that changes the text in all regions:');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&lt;upcase&gt;text&lt;/upcase&gt; to uppercase.');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&lt;lowcase&gt;text&lt;/lowcase&gt; to lowercase');
    jsConsole.writeLine(' &nbsp;&nbsp;&nbsp;&nbsp;&lt;mixcase&gt;text&lt;/mixcase&gt; to mix casing(random)');

    solutionText();

    submit.onclick = function () {

        var input = input1.value,
            parsed;

        parsed = parseTags(input);


        // My first try for automat - it is very ugly piece of code :D but seems to work properly
        function parseTags(text) {
            var inTag = false,
                afterOpenTag = false,
                afterClosingTag,
                inUpperCase = false,
                inLowerCase = false,
                inMixCase = false,
                i,
                len,
                trueOrFalse,
                result = '',
                activeUpperCase = 0,
                activeLowerCase = 0,
                activeMixedCase = 0,
                upperCount = 0,
                lowerCount = 0,
                mixedCount = 0;

            for (i = 0, len = text.length; i < len; i += 1) {
                if (text[i] === '<') {
                    inTag = true;
                    afterOpenTag = true;
                }

                if (inTag && afterOpenTag && text[i] === '/') {
                    afterClosingTag = true;
                    afterOpenTag = false;
                }

                if (inTag && afterOpenTag && text[i] === 'u') {
                    inUpperCase = true;
                    afterOpenTag = false;
                    activeUpperCase += 1;
                    upperCount += 1;
                    if (inLowerCase) {
                        activeLowerCase -= 1;
                    }
                    if (inMixCase) {
                        activeMixedCase -= 1;
                    }
                }

                if (inTag && afterOpenTag && text[i] === 'l') {
                    inLowerCase = true;
                    afterOpenTag = false;
                    activeLowerCase += 1;
                    lowerCount += 1;
                    if (inUpperCase) {
                        activeUpperCase -= 1;
                    }
                    if (inMixCase) {
                        activeMixedCase -= 1;
                    }
                }
                if (inTag && afterOpenTag && text[i] === 'm') {
                    inMixCase = true;
                    afterOpenTag = false;
                    activeMixedCase += 1;
                    mixedCount += 1;
                    if (inUpperCase) {
                        activeUpperCase -= 1;
                    }
                    if (inLowerCase) {
                        activeLowerCase -= 1;
                    }
                }

                if (inTag && afterClosingTag && text[i] === 'u') {
                    afterClosingTag = false;
                    activeUpperCase -= 1;
                    upperCount -= 1;
                    if (!upperCount) {
                        inUpperCase = false;
                    }
                    if (inLowerCase) {
                        activeLowerCase += 1;
                    }
                    if (inMixCase) {
                        activeMixedCase += 1;
                    }
                }
                if (inTag && afterClosingTag && text[i] === 'l') {
                    afterClosingTag = false;
                    activeLowerCase -= 1;
                    lowerCount -= 1;
                    if (!lowerCount) {
                        inLowerCase = false;
                    }
                    if (inUpperCase) {
                        activeUpperCase += 1;
                    }
                    if (inMixCase) {
                        activeMixedCase += 1;
                    }
                }
                if (inTag && afterClosingTag && text[i] === 'm') {
                    afterClosingTag = false;
                    console.log('-m' + inMixCase);
                    activeMixedCase -= 1;
                    mixedCount -= 1;
                    console.log('-active - m ' + activeMixedCase);
                    if (!mixedCount) {
                        inMixCase = false;
                        console.log('- m' + inMixCase)
                    }
                    if (inUpperCase) {
                        activeUpperCase += 1;
                    }
                    if (inLowerCase) {
                        activeLowerCase += 1;
                    }
                }

                if (!inTag && inUpperCase && (activeUpperCase > activeLowerCase && activeUpperCase > activeMixedCase)) {
                    result += text[i].toUpperCase();
                }
                if (!inTag && inLowerCase && (activeLowerCase > activeUpperCase && activeLowerCase > activeMixedCase)) {
                    result += text[i].toLowerCase();
                }
                if (!inTag && inMixCase && (activeMixedCase > activeLowerCase && activeMixedCase > activeUpperCase)) {
                    trueOrFalse = Math.round(Math.random());
                    if (trueOrFalse) {
                        result += text[i].toUpperCase();
                    } else {
                        result += text[i].toLowerCase();
                    }
                }

                if (!inTag && !inLowerCase && !inUpperCase && !inMixCase) {
                    result += text[i];
                }

                if (text[i] === '>') {
                    inTag = false;
                }
            }
            return result;
        }

        input = input.replace(/</g, '&lt;');
        input = input.replace(/>/g, '&gt;');

        printResult(parsed, input);

        function printResult(parsed, input) {
            jsConsole.writeLine('');
            jsConsole.writeLine('In the text: ');
            jsConsole.writeLine(input);
            jsConsole.writeLine('');
            jsConsole.writeLine('After parse:');
            jsConsole.writeLine(parsed);
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_5() {
    problemNumber.innerHTML = 'Problem 5';
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text';

    jsConsole.writeLine('Problem 5. nbsp');
    jsConsole.writeLine(' - Write a function that replaces non breaking white-spaces in a text with &<a></a>nbsp;');
    solutionText();

    submit.onclick = function () {

        var input = input1.value,
            toBeReplaced = ' ',
            replaceWith = '&<a></a>nbsp;',// little hack because &nbsp; look like space in the browser :) Otherwise <a></a> in not necessary
            result;

        result = replaceStrings(input, toBeReplaced, replaceWith);

        printResult(input, result, toBeReplaced, replaceWith);

        function replaceStrings(input, toBeReplaced, replaceWith) {
            var pattern = new RegExp(toBeReplaced, 'g');

            return result = input.replace(pattern, replaceWith);
        }

        function printResult(input, result, toBeReplaced, replaceWith) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Original text -> "' + input + '"');
            jsConsole.writeLine('To be replaced -> "' + toBeReplaced + '"');
            jsConsole.writeLine('Replaced with -> "' + replaceWith + '"');
            jsConsole.writeLine('Result tex  -> "' + result + '"');
            playWhat();
        }
    }
}

function problem_6() {
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text';
    input1.value = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
    problemNumber.innerHTML = 'Problem 6';

    jsConsole.writeLine('Problem 6. Extract text from HTML');
    jsConsole.writeLine(' - Write a function that extracts the content of a html page given as text.');
    jsConsole.writeLine(' - The function should return anything that is in a tag, without the tags.');
    solutionText();

    submit.onclick = function () {
        var input = input1.value,
            toBeReplaced = '<[^>]*>',
            replaceWith = '',
            result;

        result = replaceStrings(input, toBeReplaced, replaceWith);

        input = replaceStrings(input, '<', '&lt;');
        input = replaceStrings(input, '>', '&gt;');

        printResult(input, result, toBeReplaced, replaceWith);

        function replaceStrings(input, toBeReplaced, replaceWith) {
            var pattern = new RegExp(toBeReplaced, 'g');
            return input.replace(pattern, replaceWith);
        }

        function printResult(input, result, toBeReplaced, replaceWith) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Original text -> "' + input + '"');
            jsConsole.writeLine('');
            jsConsole.writeLine('To be replaced -> "' + toBeReplaced + '"');
            jsConsole.writeLine('Replaced with -> "' + replaceWith + '"');
            jsConsole.writeLine('');
            jsConsole.writeLine('Result text  -> "' + result + '"');
            playWhat();
        }
    }
}

function problem_7() {

    input1.style.width = '380px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter valid URL http://something.com/dir/dir';
    input1.value = 'http://telerikacademy.com/Courses/Courses/Details/239';
    problemNumber.innerHTML = 'Problem 7';

    jsConsole.writeLine('Problem 7. Parse URL');
    jsConsole.writeLine(' - Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.');
    jsConsole.writeLine(' - Return the elements in a JSON object.');
    solutionText();

    submit.onclick = function () {

        var input = input1.value,
            correctInput;

        jsConsole.writeLine('');
        jsConsole.writeLine(input);

        correctInput = (/^((http[s]?|ftp):\/)+?\/?([^:\/\s]+)((\/\w+)*)*/).test(input);

        if (correctInput) {

            var jsonObj = {
                protocol: '',
                server: '',
                resource: '',
                toString: function () {
                    return 'Protocol: ' + this.protocol + '<br/>' +
                        'Server: ' + this.server + '<br/>' +
                        'Resource: ' + this.resource;
                }
            };

            var matches = input.match(/^((http[s]?|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*)*/);

            jsonObj.protocol = matches[2];
            jsonObj.server = matches[3];
            jsonObj.resource = matches[4];

            jsConsole.writeLine(jsonObj);

            playWhat();
        }
        else {
            incorrectInput();
        }


    }
}

function problem_8() {
    input1.style.width = '380px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter valid HTML document with tags';
    input1.value = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    problemNumber.innerHTML = 'Problem 8';

    jsConsole.writeLine('Problem 8. Replace tags');
    jsConsole.writeLine(' - Write a JavaScript function that replaces in a HTML document given as string all the tags &lt;a href="…"&gt;…&lt;/a&gt; with corresponding  tags [URL=…]…/URL].');
    solutionText();


    submit.onclick = function () {

        var input = input1.value,
            result;

        // It's very specific but for the case of homework but it works :D
        result = input.replace(/<\/a>/g, '[/URL]');
        result = result.replace(/<\s*a+?\s*href="/g, '[URL=');
        result = result.replace(/("\s*>)\s*/g, ']');

        // Now some more replaces so the whole texts can be displayed on the web page

        input = input.replace(/</g, '&lt;');
        input = input.replace(/>/g, '&gt;');

        result = result.replace(/</g, '&lt;');
        result = result.replace(/>/g, '&gt;');

        jsConsole.writeLine('Input: ');
        jsConsole.writeLine(input);
        jsConsole.writeLine('');
        jsConsole.writeLine('After replace: ');
        jsConsole.writeLine(result);
        playWhat();
    }
}

function problem_9() {
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text with e-mails';
    input1.value = 'Pesho has an e-mail Pesho.Ubavetsa@mladiat.ergen. This is very rare e-mail and Gosho wants similar - sort of goshoWalker@star.wc';
    problemNumber.innerHTML = 'Problem 9';

    jsConsole.writeLine('Problem 9. Extract e-mails');
    jsConsole.writeLine(' - Write a function for extracting all email addresses from given text.');
    jsConsole.writeLine(' - All sub-strings that match the format @… should be recognized as emails.');
    jsConsole.writeLine(' - Return the emails as array of strings.');
    solutionText();

    submit.onclick = function () {
        var matches,
            input = input1.value;

        matches = input.match(/[a-zA-Z\.0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9A-Z\.!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g);

        jsConsole.writeLine('');
        jsConsole.writeLine('In the text: ');

        if (matches) {
            jsConsole.writeLine(input);
            jsConsole.writeLine('');
            jsConsole.writeLine('E-mails:');
            matches.forEach(function (mail) {
                jsConsole.writeLine(mail)
            })
        } else {
            jsConsole.writeLine('');
            jsConsole.writeLine('No e-mails found!!');
        }

    }
}

function problem_10() {
    input1.style.width = '350px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter some text';
    input1.value = 'ABBA, lamal, exe, test! word-aka. Proba? SOS.';
    problemNumber.innerHTML = 'Problem 10';

    jsConsole.writeLine('Problem 10. Find palindromes');
    jsConsole.writeLine(' - Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".');
    solutionText();

    submit.onclick = function () {

        var i,
            len,
            length,
            isPalindrome,
            input = input1.value,
            words = input.split(/[ ,\.\-!\?'"=]/g).filter(function (i) {
                if (i !== '') {
                    return i
                }
            }),
            palindromes = [];

        words.forEach(function (word) {

            isPalindrome = true;

            for (i = 0, length = word.length, len = length / 2; i < len; i += 1) {
                if (word[i] !== word[length - i - 1]) {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome) {
                palindromes.push(word);
            }
        });

        printResult(input, palindromes);

        function printResult(input, palindromes) {
            jsConsole.writeLine('');
            jsConsole.writeLine('');
            jsConsole.writeLine('In text -> ' + input);
            jsConsole.writeLine('');
            if (palindromes.length > 0) {
                jsConsole.writeLine('Palindromes :' + palindromes);
            } else {
                jsConsole.writeLine('No palindromes found!');
            }
            playWhat();
        }
    }
}

function problem_11() {
    problemNumber.innerHTML = 'Problem 11';

    jsConsole.writeLine('Problem 11. String format');
    jsConsole.writeLine(' - Write a function that formats a string using placeholders.');
    jsConsole.writeLine(' - The function should work with up to 30 placeholders and all types.');

    solutionText();

    submit.onclick = function () {

        var frmt = '{0}, {1}, {0} text {2}',
            itmA = 1,
            itmB = 'Pesho',
            itmC = 'Gosho',
            str = stringFormat(frmt, itmA, itmB, itmC);

        printResult(frmt, itmA, itmB, itmC, str);

        function stringFormat() {
            var i,
                len,
                string,
                index,
                pattern,
                placeholders,
                placesholePosition,
                matches,
                args = Array.prototype.slice.call(arguments);

            if (args.length < 2) {
                throw new Error('What the..');
                return;
            }

            string = args[0];

            matches = string.match(/{[0-9]}/g);

            for (i in matches) {
                placesholePosition = matches[i].replace(/\{/, '');
                placesholePosition = parseInt(placesholePosition);
                pattern = '\\{' + placesholePosition + '\\}';
                pattern = new RegExp(pattern, 'g');
                placesholePosition += 1;
                console.log('args - ' + placesholePosition);
                string = string.replace(pattern, args[placesholePosition]);
            }
            return string;
        }

        function printResult(str, a, b, c, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('String -> ' + str);
            jsConsole.writeLine('Placeholders -> ' + a + ', ' + b + ', ' + c);
            jsConsole.writeLine('Formated string -> ' + result);
            jsConsole.writeLine('');
            jsConsole.writeLine('More at ../strings-scripts.js');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problem_12() {
    input1.style.width = '170px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'NAME';
    input2.style.width = '170px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'AGE';
    problemNumber.innerHTML = 'Problem 12';


    jsConsole.writeLine('Problem 12. Generate list');
    jsConsole.writeLine(' - Write a function that creates a HTML &lt;ul&gt; using a template for every HTML &lt;li&gt;..');
    jsConsole.writeLine(' - The source of the list should be an array of elements.');
    jsConsole.writeLine(' - Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.');
    solutionText();

    submit.onclick = function () {

        // generate the HTML element
        var tempDiv = document.createElement('div');
        tempDiv.setAttribute('id', 'list-item');
        tempDiv.setAttribute('data-type', 'template');
        tempDiv.style.display = 'none';
        tempDiv.innerHTML = '<strong>-{name}-</strong> <span>-{age}-</span>';

        var name = input1.value,
            age = +input2.value,
            templ = tempDiv.innerHTML,
            people = [
                {name: '1-st ' + name  , age: age},
                {name: '2-nd ' + name  , age: age},
                {name: '3-rd ' + name  , age: age},
                {name: '4-th ' + name , age: age},
                {name: 'n-th ' + name , age: age}
            ];

        var peopleList = generateList(people, templ);

        function generateList(list, template) {
            var output = '<ul>',
                pattern = new RegExp(),
                currLI = '';

            for (var i = 0, len = list.length; i < len; i += 1) {

                currLI += '<li>' + template + '</li>';
                for (var item in list[i]) {
                    pattern = new RegExp('-\\{' + item + '\\}-', 'g');

                    currLI = currLI.replace(pattern, list[i][item]);
                }
                output += currLI;
                currLI = currLI.replace(/-\{[a-zA-Z]*\}-/g, '');// "DELETE" unused placeholders if such exists
                currLI = '';
            }
            output += '</ul>';
            return output; // return the result as string ready for HTML visualisation
        }

        jsConsole.writeLine('Real UL represented by jsConsole');
        jsConsole.writeLine(peopleList);

        peopleList = peopleList.replace(/</g, '&lt;');
        peopleList = peopleList.replace(/>/g, '&gt;');

        jsConsole.writeLine('Converted to see the tags');
        jsConsole.writeLine(peopleList);
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
            problem_6();
            break;
        case 7:
            playWorse();
            problem_7();
            break;
        case 8:
            problem_8();
            break;
        case 9:
            problem_9()
            break;
        case 10:
            problem_10();
            break;
        case 11:
            button_next.disabled = false;
            problem_11();
            break;
        case 12:
            button_next.disabled = true;
            playFinale();
            problem_12();
            break;
    }
}


