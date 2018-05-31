using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class AuthorCollection
    {
        readonly List<Author> authors = new List<Author>();

        public void Add(Author author)
        {
            authors.Add(author);   
        }
    }
}
