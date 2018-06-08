

namespace Lecture_2_1.ConsoleApp
{
    public class Student: Human
    {
        public Lecture Lecture;

        public Student(string fullName, Lecture lecture): base(fullName)
        {
            Lecture = lecture;            
        }

        public virtual string Learn()
        {
            return $"Student {FullName} is  studying on '{Lecture.Title}' lecture.";
        }

        protected string Sleep()
        {
            return $"Student {FullName} is  sleeping on '{Lecture.Title}' lecture.";
        }
    }
}
