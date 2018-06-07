using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class Lecture
    {
        private Professor professor;
        private Student student;
        public string Title { get; }
        public LectureType LectureType { get; }


        public Lecture(string title, LectureType lectureType)
        {
            Title = title;
            this.LectureType = lectureType;
        }
        public void AssignProfessor(Professor professor)
        {
            this.professor = professor;
            professor.Lecture = this;
        }


        public void AssignStudent(Student student)
        {
            this.student = student;
            student.Lecture = this;
        }



    }
}
