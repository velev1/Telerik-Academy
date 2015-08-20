
////!* globals $ *!/
//
////!*
//
// Create a function that takes an id or DOM element and:
// * If an id is provided, select the element
// * Finds all elements with class `button` or `content` within the provided element
// * Change the content of all `.button` elements with "hide"
// * When a `.button` is clicked:
// * Find the topmost `.content` element, that is before another `.button` and:
// * If the `.content` is visible:
// * Hide the `.content`
// * Change the content of the `.button` to "show"
// * If the `.content` is hidden:
// * Show the `.content`
// * Change the content of the `.button` to "hide"
// * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
// * Throws if:
// * The provided DOM element is non-existing
// * The id is either not a string or does not select any DOM element
//
// *!/

var toggleContentVisibility = (function () {
    function toggleContentVisibility(selector) {
        var rootElement,
            buttons,
            contents;

        //alert('ef')

        if (typeof(selector) === 'string') {
            rootElement = getDomElementByID(selector)
        } else if (selector && selector.tagName) {
            rootElement = selector;
        } else {
            throw Error('Invalid DOM element')
        }


        buttons = getButtons(rootElement);
        contents = getContents(rootElement);

        setHideToAllButtonElements(buttons);

        rootElement.addEventListener('click', function (ev) {
            var i,
                len,
                nextSibling,
                currentContent,
                clickedElement = ev.target,
                contentAfterClicked;
            //console.log(contentAfterClicked)

            if (clickedElement.className === 'button') {

               // console.log(clickedElement)

                contentAfterClicked = isContentAfterClicked(clickedElement);

                //console.log(contentAfterClicked)

                if (contentAfterClicked) {
                    if (contentAfterClicked.style.display === 'none') {
                        contentAfterClicked.style.display = '';
                        clickedElement.innerHTML = 'hide';
                    } else {
                        contentAfterClicked.style.display = 'none';
                        clickedElement.innerHTML = 'show';
                    }
                }
            }
        })
    }

    function isContentAfterClicked(clicked) {
        var nextSibl = clicked.nextElementSibling;

        //console.log(nextSibl)

        while (nextSibl) {
            if (nextSibl.className === 'button') {
                return false;
            }

            if (nextSibl.className === 'content') {
                return nextSibl;
            }

            nextSibl = nextSibl.nextElementSibling;
        }

        return false;
    }

    function setHideToAllButtonElements(buttons) {
        var i = 0,
            len = buttons.length;

        for (i; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
        }

    }

    function getButtons(root) {
        return root.getElementsByClassName('button');
    }

    function getContents(root) {
        return root.getElementsByClassName('content');
    }

    function getDomElementByID(element) {
        var domElement = document.getElementById(element);

        if (domElement) {
            return domElement
        } else {
            throw Error('Invalid DOM element ID!!')
        }
    }

    return toggleContentVisibility;
}());

//toggleContentVisibility('root')

function solve() {
    return toggleContentVisibility;

}

module.exports = solve;

