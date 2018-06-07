namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class Book
    {
        // TODO Вот они у вас все приватные. Как вы думаете с ними работать в дальнейшем?
        private Genre genre;

        private string NameBook;

        private Author Author;

        public string BookName => this.NameBook;
        public string AuthorName => this.Author?.LastName;
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
