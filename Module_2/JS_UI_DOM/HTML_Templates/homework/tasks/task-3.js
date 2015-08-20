function solve(){
  return function(){
//(function ($) {
    $.fn.listview = function (data) {
        var i,
            len,
            $this = $(this),
            templateID = $this.attr('data-template'),
            html = $('#' + templateID).html(),
            itemsTemplate = handlebars.compile(html);

        //console.log(html);
        for(i = 0, len = data.length; i< len; i+=1){
           // console.log(data[i]);
            $this.append(itemsTemplate(data[i]))

        }
        return this;
    };
//}(jQuery));

  };
}
//
//var books = [{
//        id: 1,
//        title: 'JavaScript: The Good Parts'
//    },
//        {
//            id: 2,
//            title: 'Secrets of the JavaScript Ninja'
//        },
//        {
//            id: 3,
//            title: 'JavaScript Patterns'
//        }]
//
//
//$('#books-list').listview(books);

module.exports = solve;