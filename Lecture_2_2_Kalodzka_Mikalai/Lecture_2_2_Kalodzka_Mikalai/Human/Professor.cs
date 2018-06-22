

namespace Lecture_2_2_Kalodzka_Mikalai.Human
{
    public class Professor: HomoSapiens
    {
        public Professor(string firstName, string lastName, Department department): base(firstName, lastName, department)
        {

        }

        public override string Work()
        {
            return $"Professor {FirstName} {LastName} is currently working at {Department} Department";
        }

        public override bool Equals(object obj)
        {
            // TODO Опять return true if true. Следует объединять в один return
            Professor professor = obj as Professor;
            if (professor == null)
                return false;
            else
                return (FirstName.Equals(professor.FirstName) && LastName.Equals(professor.LastName));
        }
    }
}
