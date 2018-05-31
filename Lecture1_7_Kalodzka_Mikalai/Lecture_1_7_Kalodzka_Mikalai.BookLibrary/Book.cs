using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class Book
    {
        private Genre genre;

        private string NameBook;

        private Author Author;
        
        public bool InStock;

        public Book(Genre genre, string title, Author author, bool availability)
        {
            this.genre = genre;
            NameBook = title;
            Author = author;
            InStock = availability;
        }

    }
}
