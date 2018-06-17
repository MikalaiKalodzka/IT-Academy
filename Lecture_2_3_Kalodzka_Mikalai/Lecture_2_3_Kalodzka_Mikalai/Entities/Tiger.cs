
using Lecture_2_3_Kalodzka_Mikalai.Nature;


namespace Lecture_2_3_Kalodzka_Mikalai.Entities
{
    public class Tiger: Beast
    {
        public Field Field { get; }
               
        public Tiger(Field field)
        {
            Field = field;
        }

        public override void Eat()
        {
            Field.EatRabbit();
            Hunger--;
        }

        public override void Spawn()
        {
            if (Hunger < 0)
                Field.TigerSpawn();
            else
                Eat();
        }
    }
}
