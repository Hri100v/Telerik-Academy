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

function solve() {
  return function (selector, count) {
    
    if (typeof(selector) !== 'string') {
      throw {
        name: 'CountIsNotANumberError',
        message: 'CountIsNotANumberError'
      }
    }

    if (isNaN(count) || count < 1) {
      throw {
        name: 'CountError',
        message: 'CountIsNotANumberError InvalidRangeOfCountError'
      }
    }

    var $element = $(selector);
    var $ul = $('<ul />').addClass('items-list');
    var $li = $('<li />').addClass('list-item');

    for (var i = 0; i < count; i+=1) {
      var currentLi = $li.clone(true);
      currentLi.text("List item #" + i);
      $ul.append(currentLi);
    }
    
    $element.append($ul);

    // console.log($element);
  };
};

module.exports = solve;