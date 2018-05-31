using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7_Kalodzka_Mikalai.Library
{
    public class Author
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;

        public Author(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthDate;
        }

    }
}
