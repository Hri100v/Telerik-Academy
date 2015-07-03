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
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		
		function hasDuplicatesISBN(array, oldKey) {
		    var indX,
		    	indY,
		    	len = array.length,
		    	newKey;
		    for (var indX = 0; indX < len; indX += 1) {
		    	if (array[indX].isbn === oldKey) {
		    		return true;
		    	}
		    }
		    return false
		}

		function hasDuplicatesTitle (title) {
			var index;
			for (index = 0; index < books.length; index+=1) {
				if (books[index].title === title) {
					return true;
				}
			}
			return false;
		}

		function hasDuplicatesCategory (category) {
			var index;
			for (index = 0; index < books.length; index+=1) {
				if (books[index].category === category) {
					return true;
				}
			}
			return false;
		}

		function addBook(book) {
			book.ID = books.length + 1;
			var keyISBN = book.isbn;

			// check author
			if (!book.author) {
				throw new Error('Invalid author name!')
			}

			// check title is valid
			if (book.title.length < 2 && 100 < book.title.length) {
				throw new Error('Invalid title!')
			}
			if (hasDuplicatesTitle(book.title)) {
				throw new Error('Repeated title!')
			}

			// check ISBN is valid between 10 and 13 digits
			if (keyISBN.length !== 10 && keyISBN.length !== 13) {
				throw new Error('ISBN is invalid!');
			}
			// check for ISBN it is unique
			if (hasDuplicatesISBN(books, keyISBN)) {
				throw new Error('ISBN is NOT unique!');
			}
			books.push(book);
			if (!(categories.indexOf(book.category) > -1)) {
				if (!hasDuplicatesCategory(book.category)) {
					var tempCategory = book.category;
					category.ID = categories.length + 1;
					categories.push(tempCategory);
				}
			}
			return book;
		}

/* check isExist same category*/
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
/* end of the check*/

		function listBooks(bookProp) {
			if (books.length === 0) {
				return books;
			}

			if (bookProp !== undefined) {
				if(bookProp.category !== undefined) {
					return books.filter(function (book) {
						if (book.category === bookProp.category) {
							return book;
						}
					})
				}
				if (bookProp.author !== undefined) {
					return books.filter(function (book) {
						if (book.author === bookProp.author) {
							return book;
						}
					})
				}
			}
			return books;
		}

		function listCategories() {
			books.forEach(function (book) {

                var categoryToAdd = book.category;

                if (!categories.some(function (label) {
                        return label === categoryToAdd
                    })) {
                    categories.push(book.category);
                }
            });
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