

namespace Lecture_2_1.ConsoleApp
{
    public class StudentHum: Student
    {
        public StudentHum(string fullName, Lecture lecture): base(fullName, lecture)
        {
        }

        public override string Learn()
        {             
            if (Lecture.LectureType == LectureType.Humanitarian)
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
