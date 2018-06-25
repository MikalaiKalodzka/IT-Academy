using System.Collections.Generic;
using System.Linq;
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

        // TODO Не понимаю, почему вы студента добавляете в передаваемый список,
        // а когда добавляете группу, то сохраняете их во внутреннюю группу
        // Тут то ли, просится статический метод, то ли приватный
        public void AddStudent(Student newStudent, List<Student> studentList)
        {
            if (newStudent == null)
                throw new InvalidStudentInput("new student is null");
            // TODO else можно опустить
            else if (newStudent.StudentName == null)
                throw new InvalidStudentInput("new student name is missing");
            
            // TODO Можно упростить
            if(studentList.Any(student => Equals(newStudent)))
                    throw new InvalidStudentInput("student is already exists");
            //foreach (var student in studentList)
            //{
            //    if (student.Equals(newStudent))
            //        throw new InvalidStudentInput("student is already exists");
            //}

            studentList.Add(newStudent);
        }

        public void AddGroup(List<Student> newGroup)
        {
            var checkList = new List<Student>();
            // TODO 1. Скобки лишние.
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
