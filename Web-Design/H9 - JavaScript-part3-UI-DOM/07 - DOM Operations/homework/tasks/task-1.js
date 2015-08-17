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
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {
    // var selectElement; // = document.getElementsByTagName(element);
    // var numberOfContent = contents.length;
    // var newDiv = document.createElement('div');
    
    function validateParameter(parameter) {
      if (parameter === undefined || parameter === null) {
        throw {
          name: 'InvalidParameterError',
          message: 'InvalidParameterError'
        };
      }
    }

    function validateContents(contents) {
      var i, len;
      
      if (!Array.isArray(contents)) {
        throw {
            name: 'InvalidArgumentError',
            message: 'InvalidArgumentError'
        }
      }
      
      len = contents.length;
      for(i = 0; i < len; i += 1) {
        validateContent(contents[i]);
      }
      
      function validateContent(content) {
        var currentType = typeof(content);
        if (currentType !== "string" && currentType !== "number") {
          throw {
            name: 'InvalidContentError',
            message: 'InvalidContentError'
          }
        }
      };
    };
    
    function getValidElement(element) {
      if (typeof(element) === "string") {
        element = document.getElementById(element);
      }
      
      if (!(element instanceof HTMLElement)) {
        throw {
            name: 'InvalidHtmlElement',
            message: 'InvalidHtmlElement'
          }
      }

      return element;
    }

    function appendContentsToElement (element, contents) {
      var newDiv, fragment, index, length, divToBeAppend;
      element.innerHTML = '';
      newDiv = document.createElement('div');
      fragment = document.createDocumentFragment();
      length = contents.length;

      for(index = 0; index < length; index += 1) {
        divToBeAppend = newDiv.cloneNode(true);
        divToBeAppend.innerHTML = contents[index];
        fragment.appendChild(divToBeAppend);
      }

      element.appendChild(fragment);
    }
    
  return function (element, contents) {
    validateParameter(element);
    validateParameter(contents);
    validateContents(contents);
    element = getValidElement(element);
    appendContentsToElement(element, contents);
  };
};