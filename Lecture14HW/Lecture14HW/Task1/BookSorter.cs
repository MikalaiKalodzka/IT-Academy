using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture14HW.Task1
{

    public class BookSorter
    {
        public Catalog CatalogBooks { get; set; }

        public List<Book> Books { get; set; }

        public List<Book> BookPublishedBefore(List<Book> books, int searchYear)
        {
            var listBook = new List<Book>();
                       
            var bookSearchYear = new DateTime(searchYear, 1, 1);


            foreach (var book in books)
            {
                if (book != null)
                {
                    if (book.BookYear < bookSearchYear)
                        listBook.Add(book);
                }
                else
                    throw new ArgumentNullException("book");
            }

            return listBook;
        }

        public List<Book> BookWithWorld(List<Book> books, string searchWord)
        {
            var listBook = new List<Book>();
               

            foreach (var book in books)
            {
                if (book != null)
                {
                    if (book.BookName.ToUpper().Contains(searchWord.ToUpper()))
                        listBook.Add(book);
                }
                else
                    throw new ArgumentNullException("book");

            }

            return listBook;
        }
    }
}
