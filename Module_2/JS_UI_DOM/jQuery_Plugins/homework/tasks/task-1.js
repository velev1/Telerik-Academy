//(function($){
//  $.fn.dropDownListHW = function(){
//    var $this = $(this),
//        ;
//
//    $this.css('display', 'none');
//
//
//
//
//    return $this;
//  }
//}(jQuery));

function solve() {
    return function (selector) {
        var i,
            len,
            $selectedDataValue,
            $selectedInnerText,
            $selected = $(selector).hide(),
            $body = $('body'),
            $dropdownList = $('<div />').addClass('dropdown-list'),
            $optionsContainer = $('<div />').addClass('options-container').css('position', 'absolute').hide(),
            $selectedOptions = $selected.children(),
            $newOption = $('<div />').addClass('dropdown-item'),
            $selectedOption = $selectedOptions.first(),
            $current = $('<div />').addClass('current').text($selectedOption.text()).attr('data-value', ''),
            $newOptions;

        //console.log($selectedOptions.first().next());

        for (i = 0, len = $selectedOptions.length; i < len; i += 1) {
            $selectedDataValue = $selectedOption.attr('value');
            $selectedInnerText = $selectedOption.text();
            var $currNewOption = $newOption.clone()
                                        .attr({
                                            'data-value': $selectedDataValue,
                                            'data-index': '' + i
                                        })
                                        .text($selectedInnerText);

            $optionsContainer.append($currNewOption);
            $selectedOption = $selectedOption.next();
        }


        $newOptions = $optionsContainer.children();

        $dropdownList.append($selected).append($current).append($optionsContainer);
        $body.append(($dropdownList));


        $current.on('click',  function(ev){
            $current.text('Select a value').attr('data-value', '');
            if($optionsContainer.not(':visible')){
                $optionsContainer.css('display', '');
            }
        });

        $newOptions.on('click',  function(ev){
            var $this = $(this),
                value = $this.attr('data-value');

            $current.text($this.text()).attr('data-value', value);
            $optionsContainer.css('display', 'none');

           // console.log( $selected.find('[value="' + value +'"]'));
            $selected.find('[value="' + value +'"]').prop('selected', true)
        })
    };
}

module.exports = solve;

