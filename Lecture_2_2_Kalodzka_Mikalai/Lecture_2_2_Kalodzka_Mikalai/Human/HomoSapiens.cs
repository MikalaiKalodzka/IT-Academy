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
            // TODO Во первых есть ?? во вторых мы не кидаем ошибки в своём коде если не планируем их логировать
            FirstName = firstName ?? throw new ArgumentNullException("FirstName");
            LastName = lastName ?? throw new ArgumentNullException("LastName");
            Department = department;
        }

        public abstract string Work();

        public override string ToString()
        {
            return $"{this.GetType().Name} - Name: {FirstName} {LastName} - Department: {Department}";
        }
    }
}
