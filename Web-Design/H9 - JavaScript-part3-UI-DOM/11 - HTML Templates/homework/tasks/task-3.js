function solve(){
  return function(){
    $.fn.listview = function(data){
      var len = data.length;
      var $this = $(this);
      var templateHtml = $('#' + $this.attr('data-template')).html();
      var template = handlebars.compile(templateHtml);

      for (var i = 0; i < len; i+=1) {
      	$this.append(template(data[i]));
      }

      return this;
    };
  };
}

module.exports = solve;