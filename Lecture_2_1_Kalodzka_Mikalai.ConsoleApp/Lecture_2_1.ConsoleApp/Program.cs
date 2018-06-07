using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var university = new University();


            var lecture0 = new Lecture("Biology", LectureType.Humanitarian);
            var lecture1 = new Lecture("Phisics", LectureType.Technician);
            var lecture2 = new Lecture("Mechanics", LectureType.Technician);
            var lecture3 = new Lecture("English", LectureType.Humanitarian);
            var lecture4 = new Lecture("Mathematics", LectureType.Technician);

            university.AddToLectureList(lecture0);
            university.AddToLectureList(lecture1);
            university.AddToLectureList(lecture2);
            university.AddToLectureList(lecture3);
            university.AddToLectureList(lecture4);



            var professor0 = new Professor("Rick Nash", lecture0);
            var professor1 = new Professor("Steve Byron", lecture1);
            var professor2 = new Professor("David Pepper", lecture2);
            var professor3 = new Professor("Jack Smith", lecture3);
            var professor4 = new Professor("Morgan Harris", lecture4);

            university.AddToPersonList(professor0);
            university.AddToPersonList(professor1);
            university.AddToPersonList(professor2);
            university.AddToPersonList(professor3);
            university.AddToPersonList(professor4);

            var student0 = new StudentTech("Linda Rot", lecture0);
            var student1 = new StudentHum("Karl Mason", lecture1);
            var student2 = new StudentHum("Rachel McDonell", lecture2);
            var student3 = new StudentTech("Philip Collins", lecture3);
            var student4 = new StudentTech("Paul Tyson", lecture4);

            university.AddToPersonList(student0);
            university.AddToPersonList(student1);
            university.AddToPersonList(student2);
            university.AddToPersonList(student3);
            university.AddToPersonList(student4);


            university.IterateLectures();
            






        }
    }

}
