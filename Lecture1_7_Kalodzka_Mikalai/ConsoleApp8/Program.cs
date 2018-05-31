using Lecture_1_7_Kalodzka_Mikalai.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7_Kalodzka_Mikalai.ConsoleApp
{
    class Program
    {
        static AuthorCollection collection = new AuthorCollection();
        static BookLibrary bookCollection = new BookLibrary();

        static void Main(string[] args)
        {
            Author author1 = new Author("Ray", "Bradbury", new DateTime(1920, 8, 22));
            Author author2 = new Author("Ben", "Elton", new DateTime(1959, 5, 3));
            Author author3 = new Author("John Ronald Reuel", "Tolkien", new DateTime(1892, 1, 3));

            collection.Add(author1);
            collection.Add(author2);
            collection.Add(author3);

            Book book1 = new Book(Genre.ScienceFiction, "Dandelion Wine", author1, true);

            Book book2 = new Book(Genre.Adventure, "Popcorn", author2, false);

            Book book3 = new Book(Genre.Fantasy, "The Lord of the Rings", author3, true);

            bookCollection.AddBook(book1);
            bookCollection.AddBook(book2);
            bookCollection.AddBook(book3);

            bookCollection.SetBookAvailable(book2);

        }
    }
}
