
using Lecture14HW.Helpers;

namespace Lecture14HW.Task2
{
    public class Student
    {
        public Student()
        {
            FirstName = Rnd.RandomFirstName;
            LastName = Rnd.RandomLastName;
            AvgMark = Rnd.RandomMark;
        }

        public Student(double avgMark, string lastName, string firstName)
        {
            AvgMark = avgMark;
            LastName = lastName;
            FirstName = firstName;
        }

        public double AvgMark { get; private set; }

        public string LastName { get; }

        public string FirstName { get; }

        public double ChangeAvgMark(Student student, double change)
        {
            return student.AvgMark += change;
        }


        public static bool operator >= (Student student1, Student student2) 
        {
            return student1.AvgMark >= student2.AvgMark;
        }

        public static bool operator <=(Student student1, Student student2)
        {
            return student1.AvgMark <= student2.AvgMark;
        }

    }   
}
