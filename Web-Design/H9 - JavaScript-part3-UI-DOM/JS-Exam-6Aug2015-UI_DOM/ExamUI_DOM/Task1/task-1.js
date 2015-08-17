function solve() {
    return function (selector, isCaseSensitive) {
        //if (isCaseSensitive !== true || isCaseSensitive !== false) {
        //    throw 'invalidBool';
        //}
        isCaseSensitive = isCaseSensitive || false;

        //if (selector === undefined || selector === null) {
        //    throw {
        //        name: 'InvalidParameterError',
        //        message: 'InvalidParameterError'
        //    };
        //}

        //if (typeof(selector) !== 'string') {
        //    throw {
        //        name: 'InvalidStringError',
        //        message: 'InvalidStringError'
        //    };
        //}

        //if (!(selector instanceof HTMLElement)) {
        //    throw {
        //        name: 'InvalidHtmlElement',
        //        message: 'InvalidHtmlElement'
        //    }
        //}

        var node = document.querySelector(selector);
        var container = document.createElement('div');

        var firstCont = document.createElement('div');
        firstCont.className('items-list');
        var label = document.createElement('label');
        label.innerText = 'Enter text';
        var inputF = document.createElement('input');
        var buttonF = document.createElement('button');
        buttonF.setAttribute('value', 'Add');

        var secondCont = document.createElement('div');
        secondCont.className('list-item');
        var labelSec = document.createElement('label');
        labelSec.innerText = 'Search';
        var inputSec = document.createElement('input');


        firstCont.appendChild(label);
        firstCont.appendChild(inputF);
        firstCont.appendChild(buttonF);
        secondCont.appendChild(labelSec);
        secondCont.appendChild(inputSec);

        container.appendChild(firstCont);
        container.appendChild(secondCont);


        node.appendChild(container);

  };
}

module.exports = solve;