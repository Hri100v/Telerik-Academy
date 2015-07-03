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
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
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
    // var element;
    function isValidType (element) {
      if (!element) {
        return false;
      }

      if (typeof element !== 'string') {
        return false;
      }

      if (!(/^[A-Z0-9]+$/i.test(element))) {
        return false;
      }

      return true;
    }

    function isValidAttribute (attribute) {
      if (typeof attribute !== 'string') {
        return false;
      }

      if (!(/^[A-Z0-9\-]+$/i.test(attribute))) {
        return false;
      }

      return true;
    }

    function getSortedAttributesString (attributes) {
      var attributesString = '';
      var keys = [];

      for (var key in attributes) {
        keys.push(key)
      }

      keys.sort();
      var currentKey;

      for (var i = 0; i < keys.length; i+=1) {
        currentKey = keys[i];
        attributesString = attributesString + ' ' + currentKey + '="' + attributes[currentKey] + '"';
      }

      return attributesString;
    }

		var domElement = {
      //constructor
			init: function(type) {
        this.type = type;
        this.content = '';
        this.children = [];
        this.parent;
        this.attributes = [];

        return this;
			},
      // additional to constructor
			appendChild: function(child) {
        this.children.push(child);

        if (typeof child === 'object') {
          child.parent = this;
        }

        return this;
			},
			addAttribute: function(name, value) {
        if (!isValidAttribute(name)) {
          throw new Error('Invalid attribute!');
        }
        this.attributes[name] = value;
        return this;
			},
      removeAttribute: function(attribute) {
        if (!this.attributes[attribute]) {
          throw new Error('There is not this attribute!')
        }

        delete this.attributes[attribute];

        return this;
      },

      //properties
      get innerHTML(){
        var tagResult = '<' + this.type;
        var attributesString = getSortedAttributesString(this.attributes);
        tagResult += attributesString + '>';

        var child;
        for (var i = 0; i < this.children.length; i+=1) {
          child = this.children[i];

          if (typeof child === 'string') {
            tagResult += child;
          } else {
            tagResult += child.innerHTML;
          }
        }

        tagResult += this.content;
        tagResult += '</' + this.type + '>';

        return tagResult;
      },
      get type() {
        return this._type;
      },
      set type(value) {
        if(!isValidType(value)) {
          throw new Error('Invalid type!');
        }
        return this._type = value;
      },
      get content() {
        if (this.children.length) {
          return '';
        }

        return this._content;
      },
      set content(value) {
        this._content = value;
      },
      get children() {
        return this._children;
      },
      set children(value) {
        this._children = value
      },
      get attributes() {
        return this._attributes;
      },
      set attributes(value) {
        this._attributes = value;
      },
      get parent() {
        return this._parent;
      },
      set parent(value) {
        this._parent = value;
      }
      //methods
		};
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;
