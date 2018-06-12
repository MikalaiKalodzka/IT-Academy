﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_2_Kalodzka_Mikalai.Human
{
    public class Student: HomoSapiens
    {
        public Student(string firstName, string lastName, Department department): base(firstName, lastName, department)
        {

        }        
        
        public override string Work()
        {
            return $"Student {FirstName} {LastName} is currently studying at {department} Department";
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
                return false;
            else
                return (FirstName.Equals(student.FirstName) && LastName.Equals(student.LastName));                      
        }       
    }
}
