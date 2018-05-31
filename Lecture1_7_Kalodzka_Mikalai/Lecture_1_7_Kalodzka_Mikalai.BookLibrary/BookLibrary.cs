using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class BookLibrary
    {
        readonly List<Book> bookList = new List<Book>();

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public bool SetBookAvailable(Book book)
        {
            return book.InStock = true;
        }

        public bool SetBookUnavailable(Book book)
        {            
            return book.InStock = false;
        }

    }
}
