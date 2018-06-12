using System;
using System.Collections.Generic;

using Lecture_2_2_Kalodzka_Mikalai.Human;

namespace Lecture_2_2_Kalodzka_Mikalai.La_la_land
{
    public class University
    {
        private List<HomoSapiens> persons = new List<HomoSapiens>();

        public University()
        {

        }

        public University(List<HomoSapiens> persons)
        {
            if (persons == null)
                throw new ArgumentNullException("persons");
            else
            {
                foreach (var person in persons)
                {
                    AddPerson(person);
                }
            }
        }

        public void AddPerson(HomoSapiens newPerson)
        {
            if (newPerson == null)
                throw new ArgumentNullException("newPerson");
            foreach (var person in persons)
            {
                if (person.Equals(newPerson))
                {
                    throw new ArgumentException("University already has this person", "newPerson");
                }
            }
            persons.Add(newPerson);
        }

        public List<string> GetUniversityList()
        {
            var position = new List<string>();
            foreach (var person in persons)
            {
                var student = person as Student;
                var professor = person as Professor;
                var headprofessor = person as HeadOfDepartment;
                
                if (student != null)
                {
                    string message = student.Work();
                    position.Add(message);
                }
                else if(professor != null)
                {
                    string message = professor.Work();
                    position.Add(message);
                }
                else if(headprofessor != null)
                {
                    string message = headprofessor.Work();
                    position.Add(message);
                }
            }
            return position;
        }
    }
}
