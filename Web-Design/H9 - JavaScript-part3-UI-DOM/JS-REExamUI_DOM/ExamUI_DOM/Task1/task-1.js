function solve() {
    return function (selector, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;
        
        if (selector === undefined || selector === null) {
            throw {
                name: 'InvalidParameterError',
                message: 'InvalidParameterError'
            };
        }

        if (typeof(selector) !== 'string') {
            throw {
                name: 'InvalidStringError',
                message: 'InvalidStringError'
            };
        }

        var node = document.querySelector(selector);

        var container = document.createElement('div');
        container.className = 'items-control';

        // ----- add panel -----
        var addList = document.createElement('div');
        addList.className = 'add-controls';

        var labelForAdd = document.createElement('label');
        labelForAdd.innerHTML = 'Enter text:';
        labelForAdd.setAttribute('for', 'input-add');
        var inputAdd = document.createElement('input');
        inputAdd.id = 'input-add';
        addList.appendChild(labelForAdd);
        addList.appendChild(inputAdd);

        // Button
        var buttonAdd = document.createElement('button');
        buttonAdd.innerHTML = 'Add';
        buttonAdd.className = 'button';
        
        function isEmpty(string) {
            return (!string || !string.trim());
        }

        buttonAdd.addEventListener('click', function () {
            var ulToAddTo = document.querySelector('.items-list');
            var li = document.createElement('li');
            li.className = 'list-item';
            var content = document.querySelector('#input-add').value;

            var buttonDelete = document.createElement('div');
            buttonDelete.innerHTML = 'X';
            buttonDelete.className = 'button';

            if (!isEmpty(content)) {
                li.appendChild(buttonDelete);
                li.innerHTML += content;
                ulToAddTo.appendChild(li);
            }
        }, false);

        addList.appendChild(buttonAdd);

        // ----- search panel -----
        var searchList = document.createElement('div');
        searchList.className = 'search-controls';

        var labelForSearch = document.createElement('label');
        labelForSearch.innerHTML = 'Search:';
        labelForSearch.setAttribute('for', 'input-search');
        var inputSearch = document.createElement('input');
        inputSearch.id = 'input-search';
        searchList.appendChild(labelForSearch);
        searchList.appendChild(inputSearch);

        inputSearch.addEventListener('input', function () {
            var recievedValue = this.value;
            var allLiItems = document.querySelectorAll('.items-list .list-item');

            if (allLiItems.length === 0) {
                return;
            }

            for (var i = 0, len = allLiItems.length; i < len; i += 1) {
                var startIndex = allLiItems[i].innerHTML.indexOf('</div>');
                var content = allLiItems[i].innerHTML.substr(startIndex + 6);
                
                if (!isCaseSensitive) {
                    if (content.toLowerCase().indexOf(recievedValue.toLowerCase()) < 0) {
                        allLiItems[i].style.display = 'none';
                    } else {
                        allLiItems[i].style.display = '';
                    }
                } else {
                    if (content.indexOf(recievedValue) < 0) {
                        allLiItems[i].style.display = 'none';
                    } else {
                        allLiItems[i].style.display = '';
                    }
                }
            }
        }, false);

        // ----- result panel -----
        var resultList = document.createElement('div');
        resultList.className = 'result-controls';

        var ulItemsList = document.createElement('ul');
        ulItemsList.className = 'items-list';
        resultList.appendChild(ulItemsList);
        resultList.addEventListener('click', function (ev) {
            if (ev.target.className.indexOf('button') >= 0) {
                var parent = ev.target.parentNode;
                parent.parentNode.removeChild(parent);
            }
        });
        
        container.appendChild(addList);
        container.appendChild(searchList);
        container.appendChild(resultList);

        node.appendChild(container);

  };
}

module.exports = solve;