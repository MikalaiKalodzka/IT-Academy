using System;
using System.Collections.Generic;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class AuthorCollection
    {
        // TODO Следует явно писать модификаторы доступа
        readonly List<Author> authors = new List<Author>();

        public void Add(Author author)
        {

            if(author == null)
                throw new ArgumentNullException("author");

            authors.Add(author);   
        }

        // TODO Тут могли быть ваши методы для доступа и просмотра коллекции =)
    }
}
