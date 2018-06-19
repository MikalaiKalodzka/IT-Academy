
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
            // TODO NOooooooOOOooOOOo.... 
            // Нельзя так =)) Ну нельзя кролику ходить на поле и создавать там новых кроликов.
            if (Hunger < 0)
                Field.RabbitSpawn();
            else
                Eat();
            // TODO Если сыт то плодиться, если нет - жрать. Ой я даже прослезился. 
            // Но в рамках этого метода это не правильно, они несут разный смысл...
            // только если кролик не есть партнёра если голоден
        }
    }
}
