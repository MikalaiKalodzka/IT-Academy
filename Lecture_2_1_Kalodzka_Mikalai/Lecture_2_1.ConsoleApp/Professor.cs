using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class Professor: Human
    {
        public Professor(string fullName, Lecture lecture) : base(fullName, lecture)
        {
        }

        public void Work(Professor professor)
        {
            string text = $"Professor {base.FullName} is on the {Lecture.Title}.";
        }

        
    }
}
