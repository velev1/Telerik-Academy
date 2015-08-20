/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neither `string` or `number`
 * In that case, the content of the element **must not be** changed
 */
var divChanger = (function () {
    function divChanger(element, contents) {
        var domElement,
            contentElements,
            correctContentElements = checkContentsElements(contents);

        if (typeof(element) === 'string') {
            domElement = getDomElementByID(element)
        } else if (element && element.tagName) {
            domElement = element;
        } else {
            throw Error('Invalid DOM element')
        }

        if (correctContentElements) {
            contentElements = contents;
        }

        clearElementPreviousContent(domElement);
        addContentToElement(domElement, contentElements);
    }

    function addContentToElement(element, contents) {
        var documentFr = document.createDocumentFragment(),
            divElement = document.createElement('div'),
            len = contents.length,
            i = 0;

        for (i ; i < len; i += 1) {
            var newDiv = divElement.cloneNode(true);
            newDiv.innerHTML = contents[i].toString();
            documentFr.appendChild(newDiv);
        }

        element.appendChild(documentFr);
    }

    function clearElementPreviousContent(element) {
        var lastChild;
        while (lastChild = element.lastChild) {
            element.removeChild(lastChild);
        }
    }

    function checkContentsElements(contents) {
        if (!Array.isArray(contents)) {
            throw Error('Contents mus be an array!')
        }

        contents.forEach(function (item) {
            if (typeof(item) !== 'string' && typeof(item) !== 'number') {
                throw Error('Content elements must be string or number');
            }
        });

        return true;
    }

    function getDomElementByID(element) {
        var domElement = document.getElementById(element);

        if (domElement) {
            return domElement
        } else {
            throw Error('Invalid DOM element ID!!')
        }
    }

    return divChanger;
}());
//
//var testElement = document.getElementById('test');
//var content = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];
//
////alert(testElement);
//
//divChanger(testElement, content);
////alert(testElement)


module.exports = function () {

    return divChanger;
};