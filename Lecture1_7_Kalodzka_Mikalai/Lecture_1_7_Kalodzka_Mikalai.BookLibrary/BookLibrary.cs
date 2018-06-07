using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class BookLibrary
    {
        readonly List<Book> bookList = new List<Book>();

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("book");
            }
            bookList.Add(book);
        }

        // TODO тут следовало использовать VOID. И этот метод должен был находить книгу в коллекции и 
        // делать её доступной.
        //public bool SetBookAvailable(Book book)
        //{
        //    if (book == null)
        //    {
        //        throw new ArgumentNullException("book");
        //    }
        //    return book.InStock = true;
        //}

        public void SetBookAvailable(Book book)
        {
            SetBookAvailable(book.BookName, book.AuthorName);
        }

        public void SetBookAvailable(string bookName, string authorName)
        {
            if(bookList == null || bookList.Any()) return;

            foreach (var book in bookList)
            {
                if (book.AuthorName == authorName && book.BookName == bookName)
                    book.InStock = true;
            }
        }

        public bool SetBookUnavailable(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("book");
            }
            return book.InStock = false;
        }

    }
}
