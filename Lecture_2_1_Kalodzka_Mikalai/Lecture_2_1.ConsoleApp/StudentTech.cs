namespace Lecture_2_1.ConsoleApp
{
    public class StudentTech : Student
    {
        public StudentTech(string fullName, Lecture lecture) : base(fullName, lecture)
        {
        }

        public override string Learn() // TODO По логике вы скорее передаёте сюда лекцию, а студент либо учится либо спит =))
        {
            if (Lecture.LectureType == LectureType.Technician)
            {
                return base.Learn();
            }
            else
            {
                return base.Sleep();
            }
        }
    }
}