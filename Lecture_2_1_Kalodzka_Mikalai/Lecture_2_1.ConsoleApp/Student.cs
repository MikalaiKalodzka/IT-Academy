namespace Lecture_2_1.ConsoleApp
{
    public class Student : Human
    {
        public Student(string fullName, Lecture lecture) : base(fullName, lecture)
        {
        }
        // TODO Вот тут лекциия скорее должна быть.

        public virtual string Learn()
        {
            // TODO Почему бы сразу не вернуть значение?
            return $"Student {FullName} is  studying on '{Lecture.Title}' lecture.";
            //string learnText = $"Student {FullName} is  studying on '{Lecture.Title}' lecture.";
            //return learnText;
        }

        protected string Sleep()
        {
            string sleepText = $"Student {FullName} is  sleaping on '{Lecture.Title}' lecture.";
            return sleepText;
        }
    }
}