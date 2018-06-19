using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture14HW.Task1
{
    public class Book
    {
        public string BookName { get; set; }

        public string BookAuthor { get; set; }

        public DateTime BookYear { get; set; }

        public Book(string bookName, string bookAuthor, DateTime bookYear)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            BookYear = bookYear;
        }

        public override string ToString()
        {
            return $"Book Title: {BookName} | Book Author: {BookAuthor} | Year: {BookYear.Year}";
        }

    }
}
