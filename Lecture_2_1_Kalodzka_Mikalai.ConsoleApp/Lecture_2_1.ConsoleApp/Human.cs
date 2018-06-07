using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class Human
    {
        public string FullName { get; set; }

        public Lecture Lecture { get; set; }

        public Human(string fullName, Lecture lecture)
        {
            FullName = fullName;
            Lecture = lecture;
        }

    }
}
