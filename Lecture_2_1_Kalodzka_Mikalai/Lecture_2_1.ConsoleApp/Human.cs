namespace Lecture_2_1.ConsoleApp
{
    public class Human
    {
        public string FullName { get; set; } // TODO Нужен ли тут сеттер?

        public Lecture Lecture { get; set; } // TODO Мне кажется что лекция на уровне человека не должна быть объявлена

        public Human(string fullName, Lecture lecture)
        {
            FullName = fullName;
            Lecture = lecture;
        }
    }
}