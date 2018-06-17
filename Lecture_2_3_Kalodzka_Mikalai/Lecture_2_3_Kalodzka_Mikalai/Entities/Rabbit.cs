
using Lecture_2_3_Kalodzka_Mikalai.Nature;

namespace Lecture_2_3_Kalodzka_Mikalai.Entities
{
    public class Rabbit : Beast
    {
        private Field Field { get; }

        public Rabbit(Field field)
        {
            Field = field;
        }

        public override void Eat()
        {
            Hunger--;
        }

        public override void Spawn()
        {
            if (Hunger < 0)
                Field.RabbitSpawn();
            else
                Eat();
        }
    }
}
