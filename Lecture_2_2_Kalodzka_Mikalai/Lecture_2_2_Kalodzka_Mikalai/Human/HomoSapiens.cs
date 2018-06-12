using System;


namespace Lecture_2_2_Kalodzka_Mikalai.Human
{
    public abstract class HomoSapiens
    {
        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public Department Department { get; }

        public HomoSapiens(string firstName, string lastName, Department department)
        {
            if (firstName == null)
                throw new ArgumentNullException("FirstName");
            FirstName = firstName;
            if (lastName == null)
                throw new ArgumentNullException("LastName");
            LastName = lastName;
            Department = department;
        }

        public abstract string Work();

        public override string ToString()
        {
            return $"{this.GetType().Name} - Name: {FirstName} {LastName} - Department: {Department}";
        }
    }
}
