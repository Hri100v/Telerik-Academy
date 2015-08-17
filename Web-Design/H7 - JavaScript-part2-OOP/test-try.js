var db = (function() {
	var objs = [],
		result;
	function add(obj) {
		// console.log('Adding' + obj);
		objs.push(obj);
		// return result;
		return list;
	}
	function list() {
		// console.log('Listing');
		return objs.slice();
	}
	result = {
		add: add,
		list: list
	};
	return result;
}());

function print(object) {
	console.log('item' + ' <-> ' + 'value');
	for(var item in object) {
		// console.log(item);
		console.log(item + ' <-> ' + object[item]);
	}
}
// print(db);

console.log(db.add('Goshko')())
// console.log(db.add('Goshko')
// 			.add('Penka').
// 			list());


// blank of task 1
/*
/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
/*
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks() {
			return books;
		}

		function addBook(book) {
			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
*/

var categories = ['one', 'two', 'three'];

// var hasSame = categories.forEach(function(element, item) {
// 				// console.log(element+' <-> '+ item +' <-> '+categories[item])
// 				// return (element !== categories[item]);
// 			});

// console.log(categories)
// console.log(hasSame)

function compareHasSameCat (arrayCat) {
	// if (!arrayCat.length) {
	// 	return false;
	// }
	var indA,
		indB,
		lenArrC = arrayCat.length;
	for(indA = 0; indA < lenArrC - 1; indA+=1) {
		for (indB = indA + 1; indB < lenArrC; indB+=1) {
			if (arrayCat[indA] === arrayCat[indB]) {
				return false;
			}
		}
	}
	return true;
}

console.log();
var cat = [];
cat.push('Lelin')
cat.push('Dedov')
cat.push('Dedoviqt')


console.log(cat);

function hasDuplicates(array) {
    var valuesSoFar = {};
    for (var i = 0; i < array.length; ++i) {
        var value = array[i];
        if (Object.prototype.hasOwnProperty.call(valuesSoFar, value)) {
            return true;
        }
        valuesSoFar[value] = true;
    }
    return false;
}

// console.log(hasDuplicates(cat))

var addBook = {
	title: 'JohnDoe',
	isbn: '1234567890123',
	author: 'Doun Brown',
	category: 'Fantasy'
};

var keyISBN = addBook.isbn.length

// console.log(keyISBN)

// console.log(addBook.author !== 'undefined')

var books = [];
var b1 = {
	title: 'Unique Doe',
	isbn: '1234567890',
	author: 'Johne Bravo',
	category: 'Comics'
}

books.push(addBook)
books.push(b1)

function hasDuplicatesTitle (title) {
			var index;
			for (index = 0; index < books.length; index+=1) {
				if (books[index].title === title) {
					return true;
				}
			}
			return false;
		}

var categories = [];
categories.push(addBook.category)
categories.push(b1.category)
// console.log(categories)
// console.log(categories.indexOf('Comics'))


///
var bust = 'Asd#12';

console.log(/^[A-Z0-9]+$/i.test(bust))

function splitFullname (fullname) {
    // body...
    var names = fullname.split(' '),
    	fname = names[0],
    	lname = names[1];
    // return {
    // 	fname: fname,
    // 	lname: lname
    // }
    return names;
}

var testNames = splitFullname('Nikodim Todorov');
console.log(testNames['lname'] + ' ' + testNames.fname);

var whiteSpaceTitle = 'Title something!';
var isMatch = !/\s{2,}/.test(whiteSpaceTitle);
console.log(isMatch)

var lastID = 0;
function getID () {
	return ++lastID;
}
var studentsList = [];
var Course = {
	addStudent: function(name) {
	      // validateName(name);
	      var student = {
	        firstname: splitFullname(name)[0],
	        lastname: splitFullname(name)[1],
	        id: getID()
	      }
	      // console.log(student)
	      studentsList.push(student);
	},
	getAllStudents: function() {
      //{firstname: 'string', lastname: 'string', id: StudentID}
      var arrayOfStudents = [],
          currentStudentInfo = {};
      for(var student of studentsList) {
        // currentStudentInfo = {
        //   firstname: this.fname, 
        //   lastname: this.lname, 
        //   id: this.id
        // }
        arrayOfStudents.push(student);
      }

      return arrayOfStudents;
	}
}

console.log(splitFullname('Test Testov')[1])

Course.addStudent("Pepi Petrov");
Course.addStudent("Ivan Ivanov");

console.log(Course.getAllStudents())


var title = ' '
console.log(title.trim() === '')
// title !== title.trim()
console.log(title !== title.trim())
var presentations = 'With pres1';
console.log(!Array.isArray(presentations))

 if (!Array.prototype.findIndex) {
        Array.prototype.findIndex = function(predicate) {
            if (this == null) {
                throw new TypeError('Array.prototype.findIndex called on null or undefined');
            }
            if (typeof predicate !== 'function') {
                throw new TypeError('predicate must be a function');
            }
            var list = Object(this);
            var length = list.length >>> 0;
            var thisArg = arguments[1];
            var value;

            for (var i = 0; i < length; i++) {
                value = list[i];
                if (predicate.call(thisArg, value, i, list)) {
                    return i;
                }
            }
            return -1;
        };
    }


console.log('---------------------');
var playlists = [{name:'Mata', id: 1}, {name:'Hara', id: 2}, {name:'Kosmata', id: 3}];
var id = 3;
var ind = playlists.findIndex(function (playable) {
	return playable.id === id;
});

console.log(ind)
console.log(playlists[2])
var alpha = ['a', 'b', 'c', 'd', 'e',]
console.log(alpha.slice(2, 3))