/* globals $ */

/* 

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

var ulCreator = (function () {

    function ulCreator(selector, count) {

        var i,
            $newLi,
            $root,
            $ul = $('<ul />').addClass('items-list'),
            $li = $('<li />').addClass('list-item');

        validateSelector(selector);
        validateCount(count);

        $root = $(selector);


        for (i = 0; i < +count; i += 1) {
            $newLi = $li.clone(true).html('List item #' + i);
            $ul.append($newLi);
        }

        $root.append($ul)
    }

    function validateSelector(selector) {
        if (typeof(selector) !== 'string') {
            throw Error('Invalid selector!')
        }
    }

    function validateCount(count){
        var count = +count;

        if(isNaN(count)){
            throw Error('Count must be number or convertible to number string');
        }

        if(count < 1){
            throw Error('Count must be greater than 1');
        }
    }

    return ulCreator;
}());

function solve() {
    return ulCreator;
}

module.exports = solve;