using System;
using System.Collections.Generic;
using System.Linq;


namespace Lecture14HW.Task2
{
    public delegate bool CompareDelegate(Student firstStudent, Student secondStudent);

    public delegate bool StudentSelector(Student student);

    public delegate List<Student> StudentSort(List<Student> students);

    public class Group
    {
        private readonly List<Student> _students = new List<Student>();

        public IEnumerable<Student> Students
        {
            get
            {
                foreach (var Student in Students)
                {
                    yield return Student;
                }	
            }
        }

        public Group(List<Student> students)
        {
            _students = students;
        }


        public Student this[int index]
        {
            get
            {
                return _students[index];
            }
            set
            {
                _students[index] = value;
            }
        }

        public List<Student> GetStudents(StudentSelector selector)
        {
            var listStudent = new List<Student>();

            foreach (var student in listStudent)
            {
                if (selector(student)) listStudent.Add(student);
            }

            return listStudent;
        }
                
        public void DoSmth(Action<Student> action)
        {
            foreach (var student in _students)
            {
                action(student);
            }
        }

        public List<Student> SortStudents(CompareDelegate compareMethod)
        {
            Student[] sortList = new Student[_students.Count];
            _students.CopyTo(sortList);

            for (int i = sortList.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (compareMethod(sortList[j], sortList[j + 1]))
                    {
                        Student compare = sortList[j];
                        sortList[j] = sortList[j + 1];
                        sortList[j + 1] = compare;
                    }
                }
            }
            return sortList.ToList();
        }
    }
}
