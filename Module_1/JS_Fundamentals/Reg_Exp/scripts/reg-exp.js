function problem_1() {
    problemNumber.innerHTML = 'Problem 1';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter options [ name: "John" ]';
    input1.value = 'name: "John", age: 13';
    input2.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter string';
    input2.value = 'My name is #{name} and I am #{age}-years-old';

    jsConsole.writeLine('Problem 1. Format with placeholders');
    jsConsole.writeLine(' - Write a function that formats a string. The function should have placeholders, as shown in the example');
    jsConsole.writeLine('&nbsp;&nbsp;&nbsp;&nbsp;&bull;Add the function to the String.prototype');
    solutionText();

    // here is the Reg Exp function - returns =new string, and keeps the original
    String.prototype.format = function (options) {
        // accept options as object
        var result = this,
            pattern,
            prop;

        for (prop in options) {
            pattern = new RegExp('#\\{' + prop + '\\}');
            result = result.replace(pattern, options[prop]);
        }

        return result;
    };

    submit.onclick = function () {
        var input = input1.value.split(','),
            theString = input2.value,
            formatted,
            options = {
                toString: function () { // for visualisation on the web page
                    var output = '';
                    for (var prop in this) {
                        if (prop != 'toString') {
                            output += prop + ': ' + this[prop] + ', ';
                        }
                    }
                    return output;
                }
            };

        // this is just to parse the input as object!!
        for (var i in input) {
            var props = input[i].split(/: /g);
            options[props[0].trim()] = props[1].replace(/[ '"]/g, '');
        }

        // Applying the format function
        formatted = theString.format(options);

        printResult(theString, options, formatted)


        function printResult(string, options, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Options: ' + options);
            jsConsole.writeLine('');
            jsConsole.writeLine('String: ' + string);
            jsConsole.writeLine('');
            jsConsole.writeLine('Formatted: ' + result);
            jsConsole.writeLine('------------------------------------------------------------------');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}
function problem_2() {
    problemNumber.innerHTML = 'Problem 2';
    input1.style.width = '200px';
    input1.style.visibility = 'visible';
    input1.placeholder = 'Enter options [ name: "Steven" ]';
    input1.value = "name: 'Elena', link: 'http://telerikacademy.com'";
    input2.style.width = '200px';
    input2.style.visibility = 'visible';
    input2.placeholder = 'Enter string';
    input2.value = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';

    jsConsole.writeLine('Problem 2. HTML binding');
    jsConsole.writeLine(' - Write a function that puts the value of an object into the content/attributes of HTML tags.');
    jsConsole.writeLine('&nbsp;&nbsp;&nbsp;&nbsp;&bull;Add the function to the String.prototype');
    solutionText();

    // here is the Reg Exp function - returns =new string, and keeps the original
    String.prototype.bind = function (options) {
        // accept options as object
        var result = this,
            matches,
            pattern;

        for (var prop in options) {
            pattern = new RegExp('data-bind-[a-z]*="' + prop.trim() + '"', 'g');
            matches = result.match(pattern);//[0].match(/[a-z]*=/gi);
            for (var item in matches) {
                var attribute,

                    attribute = matches[item].match(/[a-z]*=/gi)[0].trim().toLowerCase();
                console.log(attribute);
                if (attribute == 'content=') {
                    result = result.replace(/></, '>' + options[prop].trim() + '<');
                } else {
                    result = result.replace(/" *>/g, '" ' + attribute + '"' + options[prop] + '">');
                }
            }
        }

        return result;
    };


    submit.onclick = function () {
        var input = input1.value.split(','),
            theString = input2.value,
            formatted,
            options = {
                toString: function () { // for visualisation on the web page
                    var output = '';
                    for (var prop in this) {
                        if (prop != 'toString') {
                            output += prop + ': ' + this[prop] + ', ';
                        }
                    }
                    return output;
                }
            };

        // this is just to parse the input as object!!
        for (var i in input) {
            var props = input[i].split(/: /g);
            console.log('Reversed: ' + props[0] + ' ->' + props[1].replace(/['"]/g, ''));
            options[props[0].trim()] = props[1].replace(/[ '"]/g, '');
        }

        // Applying the format function
        formatted = theString.bind(options);

        // Replaces for correct visualisation on the web browser
        theString = theString.replace(/</g, '&lt;');
        theString = theString.replace(/>/g, '&gt;');
        formatted = formatted.replace(/</g, '&lt;');
        formatted = formatted.replace(/>/g, '&gt;');

        printResult(theString, options, formatted);


        function printResult(string, options, result) {
            jsConsole.writeLine('');
            jsConsole.writeLine('Options: ' + options);
            jsConsole.writeLine('');
            jsConsole.writeLine('String: ' + string);
            jsConsole.writeLine('');
            jsConsole.writeLine('Bind: ' + result);
            jsConsole.writeLine('------------------------------------------------------------------');
            jsConsole.writeLine('');
            playWhat();
        }
    }
}

function problemSwitch() {

    resetInputFields();
    jsConsole.clearConsole();

    switch (problemCounter) {
        case 1:
            button_prev.disabled = true;
            button_next.disabled = false;
            problem_1();
            break;
        case 2:
            playFinale();
            button_prev.disabled = false;
            button_next.disabled = true;
            problem_2();
            break;
    }
}



