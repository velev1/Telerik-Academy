///* globals $ */
//
///*
// Create a function that takes a selector and:
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
// * The provided ID is not a **jQuery object** or a `string`
//
// */
function solve() {
    return function (selector) {
        var $rootElement,
            stringSelector = typeof(selector) === 'string';

        if (selector && selector instanceof $) {
            $rootElement = selector;
        } else if (stringSelector && $(selector).size() > 0) {
            $rootElement = $(selector);
        } else {
            throw Error('Selector mut be string or jQuery object!!')
        }

        $rootElement.children('.button').html('hide');

        $rootElement.on('click', '.button', function () {
            var $this = $(this),
                $content = $this.next();

            if ($content.length === 0) {
                return;
            }

            while ($content.length > 0) {
                if ($content.hasClass('button')) {
                    return;
                }

                if ($content.hasClass('content')) {
                    break;
                }

                $content = $content.next();
            }

            if ($content.css('display') !== 'none') {
                $content.css('display', 'none');
                $this.html('show');
            } else {
                $content.css('display', '');
                $this.html('hide');
            }
        });
    };
}

module.exports = solve;
