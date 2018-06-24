using System.Collections.Generic;

using Lecture_2_6_Kalodzka_Mikalai.Exceptions;

namespace Lecture_2_6_Kalodzka_Mikalai.Entities
{

    public class StudentGroup
    {
        private readonly List<Student> _students = new List<Student>();

        public StudentGroup()
        {

        }

        public StudentGroup(List<Student> students)
        {
            _students = students;
        }
                
        public void AddStudent(Student newStudent)
        {
            AddStudent(newStudent, _students);
        }

        public void AddStudent(Student newStudent, List<Student> studentList)
        {
            if (newStudent == null)
                throw new InvalidStudentInput("new student is null");
            else if (newStudent.StudentName == null)
                throw new InvalidStudentInput("new student name is missing");
            
            foreach (var student in studentList)
            {
                if (student.Equals(newStudent))
                    throw new InvalidStudentInput("student is already exists");
            }

            studentList.Add(newStudent);
        }

        public void AddGroup(List<Student> newGroup)
        {
            var checkList = new List<Student>();
            if ((newGroup == null) || (newGroup.Count == 0))
                throw new PropertyInitializationIssue("new Group of student is null");
            
            foreach (var newStudent in newGroup)
            {
                AddStudent(newStudent, checkList);
            }

            if (newGroup.Count == checkList.Count)
                _students.AddRange(newGroup);                
        }
    }
}
