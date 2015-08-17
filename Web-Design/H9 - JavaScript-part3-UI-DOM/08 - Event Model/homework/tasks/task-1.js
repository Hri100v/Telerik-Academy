/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  
If an id is provided, select the element
Finds all elements with class button or content within the provided element
	o Change the content of all .button elements with "hide"
When a .button is clicked:
	o Find the topmost .content element, that is before another .button and:
		If the .content is visible:
			- Hide the .content
			- Change the content of the .button to "show"
		If the .content is hidden:
			- Show the .content
			- Change the content of the .button to "hide"
		If there isn't a .content element after the clicked .button and before other .button, do nothing
Throws if:
	o The provided DOM element is non-existant
	o The id is either not a string or does not select any DOM element
*/

function solve(){
	var CONST = {
		class: {
			button: 'button',
			content: 'content'
		},
		display: {
			hidden: 'none',
			visible: ''
		},
		buttonInnerHtml: {
			onHidden: 'show',
			onVisible: 'hide'
		}
	};

	function validateParameter(param) {
		if (param === undefined || param === null) {
			throw {
				name: 'InvalidParamError',
				message: 'InvalidParamUndefinedOrNullError'
			}
		}
	}

	function validateId(element) {
		if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
			throw {
				name: 'InvalidElementError',
				message: 'Invalid Element Is Not A String And Not Instance Of HTML DOM'
			}
		}
	}

	function getAllButtonsAndContents() {
		var buttonsAndContents = [];
		var buttonsInHtml = document.getElementsByClassName(CONST.class.button);
		var contentsInHtml = document.getElementsByClassName(CONST.class.content);
		buttonsAndContents.push(buttonsInHtml);
		buttonsAndContents.push(contentsInHtml);

		// console.log(buttonsAndContents);
		return buttonsAndContents;
	}

	function addEventsForButton() {
		var buttons = document.getElementsByClassName(CONST.class.button),
			contents = document.getElementsByClassName(CONST.class.content),
			i, len;

		for (i = 0, len = buttons.length; i < len; i += 1) {
			buttons[i].innerHTML = CONST.buttonInnerHtml.onVisible;
			buttons[i].addEventListener('click', function(ev) {
				var clicked = ev.target;
				var nextSibling = clicked.nextElementSibling;
				var contentElement;
				var canToggle = false;

				while(nextSibling){
					// move to all content
					if (nextSibling.className === CONST.class.content) {
						contentElement = nextSibling;
						nextSibling = nextSibling.nextElementSibling;
						// if nextSibling is button ->always canToggle = true
						while(nextSibling) {
							if (nextSibling.className === CONST.class.button) {
								canToggle = true;
								break;
							}
							nextSibling = nextSibling.nextElementSibling;
						}
						break;
					} else {
						nextSibling = nextSibling.nextElementSibling;
					}
				}

				if (canToggle) {
					// if none TODO: changes
					//else button -> show
					if (contentElement.style.display === CONST.display.hidden) {
						contentElement.style.display = CONST.display.visible
						clicked.innerHTML = CONST.buttonInnerHtml.onVisible;
					} else {
						contentElement.style.display = CONST.display.hidden;
						clicked.innerHTML = CONST.buttonInnerHtml.onHidden;
					}
				}

			});
		}

	}

	return function (selector) {
		validateId(selector);
		validateParameter(document.getElementById(selector));

		addEventsForButton();
	};
};

module.exports = solve;