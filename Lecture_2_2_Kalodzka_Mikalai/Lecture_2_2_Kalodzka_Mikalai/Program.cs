using System;


using Lecture_2_2_Kalodzka_Mikalai.Human;
using Lecture_2_2_Kalodzka_Mikalai.La_la_land;

namespace Lecture_2_2_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)

        {
            University university = new University();

            var student0 = new Student("Mike", "Polansky", Department.PowerEngineering);
            var student1 = new Student("Mary", "Beans", Department.Architectural);
            var student2 = new Student("Karl", "Peters", Department.InformationTechnologiesAndRobotics);
            var student3 = new Student("Sarah", "Hendrickson", Department.PowerEngineering);
            var student4 = new Student("Jasmine", "Caroll", Department.Architectural);

            university.AddPerson(student0);
            university.AddPerson(student1);
            university.AddPerson(student2);
            university.AddPerson(student3);
            university.AddPerson(student4);

            try
            {
                university.AddPerson(student0);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error occured while adding {student0}:\n\t{exception.Message}.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            var professor0 = new Professor("Mathew", "Jenkins", Department.PowerEngineering);
            var professor1 = new Professor("Andy", "King", Department.Architectural);
            var professor2 = new Professor("Alice", "Smith", Department.InformationTechnologiesAndRobotics);

            university.AddPerson(professor0);
            university.AddPerson(professor1);
            university.AddPerson(professor2);

            var headProfessor0 = new HeadOfDepartment("Bob", "Thornton", Department.PowerEngineering);
            var headProfessor1 = new HeadOfDepartment("Katy", "Billigan", Department.Architectural);
            var headProfessor2 = new HeadOfDepartment("Ken", "Stampkos", Department.InformationTechnologiesAndRobotics);

            university.AddPerson(headProfessor0);
            university.AddPerson(headProfessor1);
            university.AddPerson(headProfessor2);

            Console.WriteLine(string.Join("\n", university.GetUniversityList()));

            Console.ReadKey();
        }
    }
}
