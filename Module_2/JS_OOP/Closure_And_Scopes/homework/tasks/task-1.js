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

        function listBooks(sortMethod) {
            if (!sortMethod) {
                return books.sort(function (a, b) {
                    return a.id - b.id
                });
            } else if (sortMethod.category) {
                return books.filter(function (book) {
                    return book.category === sortMethod.category
                });

            } else if (sortMethod.author) {
                return books.filter(function (book) {
                    return book.author === sortMethod.author
                })
                    .sort(function (a, b) {
                        return a.id - b.id
                    });
            }
        }

        function addBook(book) {
            var title = book.title,
                category = book.category,
                isbn = book.isbn,
                author = book.author;

            checkNames(title);
            checkNames(category);
            checkISBN(isbn);
            checkAuthor(author);

            book.ID = books.length + 1;

            books.forEach(function (book) {
                if (book.title === title) {
                    throw Error('Repeating title')
                }
            });

            if (categories.indexOf(category) < 0) {
                categories[categories.length] = category;
            }

            books.push(book);

            return book;
        }

        function listCategories() {
            return categories;
        }

        function checkAuthor(author) {
            if (author.length < 1) {
                throw Error('Invalid author name!')
            }
        }

        function checkISBN(isbn) {
            var i,
                len = isbn.length;


            if (!(len == 10 || len == 13)) {
                throw Error('Invalid ISBN length (10 or 13) - assigned: ' + len);
            }

            for (i = 0; i < len; i += 1) {
                if (isNaN(isbn[i])) {
                    throw Error('Invalid ISBN character - ' + isbn[i])
                }
            }

            for (var book in books) {
                if (books[book].isbn === isbn) {
                    throw  Error('Repeating ISBN')
                }
            }
        }

        function checkNames(name) {
            if (name.length < 2 || name.length > 100) {
                throw Error('Invalid name for title or category!')
            }
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
    }());
    return library;
}
module.exports = solve;

/*
var library,
    CONSTS = {
        VALID: {
            BOOK_TITLE: 'BOOK #',
            BOOK_ISBN: {
                TEN_DIGITS: '1234567890',
                THIRTEEN_DIGITS: '1234567890123',
            },
            AUTHOR: 'John Doe',
            CATEGORY: 'Book Category'
        },
        INVALID: {
            BOOK_TITLE: {
                SHORT: 'B',
                LONG: new Array(101).join('A')
            },
            AUTHOR: '',
            BOOK_ISBN: '1234'
        }
    };

var book = {
    title: CONSTS.VALID.BOOK_TITLE,
    isbn: CONSTS.VALID.BOOK_ISBN.TEN_DIGITS,
    author: CONSTS.VALID.AUTHOR,
    category: CONSTS.VALID.CATEGORY
};
console.log([book]);
var book2 = {
    title: 'BOOK 2',
    isbn: '1234967870123',
    author: '2John Doe2',
    category: CONSTS.VALID.CATEGORY + 2
};

library = solve();
console.log(library.books.add(book));
console.log(library.books.add(book2));
console.log('-----------------')

 console.log(library.books.list({
 category: book.category
 }));
 console.log(library.books[book]);

console.log(library.categories.list());
console.log([book.category]);
*/
