using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class StudentTech: Student
    {

        public StudentTech(string fullName, Lecture lecture): base(fullName, lecture)
        {

        }

        public override string Learn()
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
