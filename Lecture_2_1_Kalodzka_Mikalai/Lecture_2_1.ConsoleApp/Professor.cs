namespace Lecture_2_1.ConsoleApp
{
    public class Professor : Human
    {
        public Professor(string fullName, Lecture lecture) : base(fullName, lecture)
        {
        }

        public void Work(Professor professor) // TODO Зачем вы передаёте сюда профессора?
        {
            // TODO Забыли вернуть? =)
            string text = $"Professor {base.FullName} is on the {Lecture.Title}.";
        }
    }
}