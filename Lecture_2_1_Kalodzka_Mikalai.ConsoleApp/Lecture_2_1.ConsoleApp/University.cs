using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_1.ConsoleApp
{
    public class University
    {
        private List<Human> persons = new List<Human>();

        private List<Lecture> lectures = new List<Lecture>();

        public University()
        {
        }

        public University(List<Human> persons, List<Lecture> lectures)
        {
            
            if (persons == null)
                throw new ArgumentNullException("persons");
            else
            {
                this.persons.AddRange(persons);
            }

            if (lectures == null)
                throw new ArgumentNullException("lectures");
            else
            {
                this.lectures.AddRange(lectures);
            }

        }


        public void AddToPersonList(Human human)
        {
            if (human == null)
                throw new ArgumentNullException("human");
            else
            {
                persons.Add(human);
            }
            
        }

        public void AddToLectureList(Lecture study)
        {
            if (lectures == null)
                throw new ArgumentNullException("lecture");
            else
            {
                lectures.Add(study);
                
            }
        }

        public void IterateLectures()
        {
            foreach (var person in persons)
            {
                var student = person as Student;
                if (student != null)
                {
                    student.Learn(student);
                }
                else
                {
                    var professor = person as Professor;
                    if (professor != null)
                    {
                        professor.Work(professor);
                    }
                }
            }
        }

                
    }
}
