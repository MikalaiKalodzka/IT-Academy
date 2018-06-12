using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_2_Kalodzka_Mikalai.Human
{
    public class HeadOfDepartment : Professor
    {
        public HeadOfDepartment(string firstName, string lastName, Department department): base(firstName, lastName, department)
        {

        }

        public override string Work()
        {
            return $"Professor {FirstName} {LastName} is currently the Head of the {department} Department";
        }

    }
}
