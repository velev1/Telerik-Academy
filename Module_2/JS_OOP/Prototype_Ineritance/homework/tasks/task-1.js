/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */

function solve() {
    var domElement = (function () {
        var _correctInput,
            _typePattern = /(^[a-zA-Z0-9]+$)/,
            _attributeNamePattern = /(^[a-zA-Z0-9\-]+$)/;

        var domElement = {
            init: function (type) {
                correctName(type, _typePattern);
                this.type = type;
                this.attributes = [];
                return this;
            },
            appendChild: function (child) {
                this.children = this.children || [];
                this.children.push(child);
                child.parent = this;
                return this;
            },
            addAttribute: function (name, value) {
                correctName(name, _attributeNamePattern);

                for (var i = 0, len = this.attributes.length; i < len; i += 1) {

                    if (this.attributes[i].name === name) {

                        this.attributes[i].value = value;
                        return this;
                    }
                }

                this.attributes.push({name: name, value: value || ''});
                return this;
            },
            removeAttribute: function (name) {
                var attributeFound = false;

                for (var i = 0, len = this.attributes.length; i < len; i += 1) {

                    if (this.attributes[i].name === name) {

                        this.attributes.splice(i, 1);
                        attributeFound = true;
                        break;
                    }
                }

                if (attributeFound) {
                    return this
                } else {
                    throw new Error('Non-existing attribute!')
                }
            },
            get innerHTML() {
                return innerHtmlToString(this);
            },
            set content(content) {
                if (!this.children) {
                    this._content = content;
                }
            },
            get parent() {
                return this._parent;
            },
            set parent(element) {
                this._parent = element;
            }
        };

        function innerHtmlToString(element) {
            var content = element._content || '',
                attributesToString = '',
                childToString = '';

            if (element.children) {
                for (var child in element.children) {
                    if (typeof element.children[child] == 'string') {
                        childToString += element.children[child];

                    } else {
                        childToString += innerHtmlToString(element.children[child]);
                    }
                }
            }

            if (element.attributes.length > 0) {
                attributesToString = ' ' + element.attributes.sort(function (a, b) {
                        return (a.name > b.name)
                    })
                        .reduce(function (result, attribute) {
                            return result += attribute.name + '=' + '"' + attribute.value + '" '
                        }, '').trim();
            } else {
                attributesToString = '';
            }

            return '<' + element.type + attributesToString + '>' + content + childToString + '</' + element.type + '>';
        }

        function correctName(name, pattern) {
            _correctInput = ((typeof name) === 'string') && (pattern.test(name));

            if (!_correctInput) {
                throw Error('Incorrect type!')
            }
        }

        return domElement;
    }());
    return domElement;
}

module.exports = solve;


//var meta = Object.create(domElement)
//    .init()
//    .addAttribute('charset', 'utf-8');

//var testelement = solve();

//var testelement33 = Object.create(testelement);
//testelement33.addAttribute('charset', 'utf-8');

//console.log(testelement33.innerHTML);
/*
 var root = Object.create(solve())
 .init('table')
 .addAttribute('style', 'something: beautiful')
 .addAttribute('id', 'the_id')
 .removeAttribute('style')
 .addAttribute('class', 'the_class');

 console.log(root.innerHTML) //.to.eql('<table class="the_class" id="the_id"></table>');

 */