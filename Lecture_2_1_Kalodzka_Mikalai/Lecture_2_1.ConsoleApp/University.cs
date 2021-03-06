﻿using System;
using System.Collections.Generic;


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

        public List<string> GetLectures()
        {
            var lectures = new List<string>();
            foreach (var person in persons)
            {
                var student = person as Student;
                if (student != null)
                {
                    string message = student.Learn();
                    lectures.Add(message);
                }
                else
                {
                    var professor = person as Professor;
                    if (professor != null)
                    {
                        string message = professor.Work();
                        lectures.Add(message);
                    }
                }
            }
            return lectures;
        }                
    }
}
