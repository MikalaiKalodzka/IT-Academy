using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class Student: Human
    {
        
        public Student(string fullName, Lecture lecture): base(fullName, lecture)
        {                    
        }

        public virtual string Learn()
        {
            string learnText = $"Student {FullName} is  studying on '{Lecture.Title}' lecture.";
            return learnText;
        }

        protected string Sleep()
        {
            string sleepText = $"Student {FullName} is  sleaping on '{Lecture.Title}' lecture.";
            return sleepText;
        }
    }
}
