using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTService.Managers
{
    public class BooksManager
    {
        public static List<Book> list = new List<Book>
        {
            new Book {ISBN13 = "111", Author = "Person1", Title = "Title1", PageNumber = 11},
            new Book {ISBN13 = "222", Author = "Person2", Title = "Title2", PageNumber = 22},
            new Book {ISBN13 = "333", Author = "Person3", Title = "Title3", PageNumber = 33},
        };

        public List<Book> GetAll()
        {
            return new List<Book>(list);
        }

        public Book GetBook(string ISBN13)
        {
            return list.Find(book => book.ISBN13.Contains(ISBN13));
        }

        public Book Add(Book newBook)
        {
            list.Add(newBook);
            return newBook;
        }

        public void Delete(string ISBN13)
        {
            var  index = list.FindIndex(book => book.ISBN13 == ISBN13);
            if (index != -1)
                list.RemoveAt(index);
        }

        public void Update(string ISBN13, Book book)
        {
            var index = list.FindIndex(book => book.ISBN13 == ISBN13);
            if (index != -1)
                list[index] = book;
        }
    }
}
