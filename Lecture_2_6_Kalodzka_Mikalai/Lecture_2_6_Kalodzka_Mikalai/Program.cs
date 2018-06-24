using System;
using System.Collections.Generic;

using Lecture_2_6_Kalodzka_Mikalai.Entities;
using Lecture_2_6_Kalodzka_Mikalai.Exceptions;

namespace Lecture_2_6_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            StudentGroup studentGroup = new StudentGroup(students);            

            var student1 = new Student("Percy Jackson");
            var student2 = new Student("Melissa Hardwood");
            var student3 = new Student("Rockie Balboa");
            var student4 = new Student("Lara Croft");
            var student5 = new Student();
            
            var studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);
            
            foreach (var student in studentList)
            {
                try
                {
                    studentGroup.AddStudent(student);
                }
                catch (InvalidStudentInput e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var newGroup1 = new List<Student>()
            {
                new Student("Alex Moreno"),
                new Student(),
                new Student("Sarah Svensson")
            };

            var newGroup2 = new List<Student>();

            try
            {
                studentGroup.AddGroup(newGroup1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                PrintStudent(students);
            }

            try
            {
                studentGroup.AddGroup(newGroup2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                PrintStudent(students);
            }


            Console.ReadKey();
        }

        static void PrintStudent(List<Student> students)
        {
            Console.WriteLine("List of students");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
