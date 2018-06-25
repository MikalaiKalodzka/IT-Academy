
namespace Lecture_2_6_Kalodzka_Mikalai.Entities
{
    public class Student
    {
        public string StudentName { get; }

        public Student()
        {
        }

        public Student(string studentName)
        {
            StudentName = studentName;
        }

        public override string ToString()
        {
            return $"Student: {StudentName}";
        }
    }
}
