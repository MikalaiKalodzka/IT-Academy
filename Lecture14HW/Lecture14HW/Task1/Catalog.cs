using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture14HW.Task1
{
    public delegate bool BookSelector(Book book);

    public class Catalog
    {
        public List<Book> Books { get; set; }

        public List<Book> GetBooks(BookSelector selector)
        {
            var listBook = new List<Book>();

            foreach (var book in listBook)
            {
                if (selector(book)) listBook.Add(book);
            }

            return listBook;
        }
    }
}
