

namespace Lecture_2_1.ConsoleApp
{
    public class Professor: Human
    {
        public Lecture Lecture;

        public Professor(string fullName, Lecture lecture) : base(fullName)
        {
            Lecture = lecture;
        }

        public string Work()
        {
            string text = $"Professor {base.FullName} is on the {Lecture.Title}.";
            return text;
        }        
    }
}
