
namespace Lecture_2_3_Kalodzka_Mikalai.Entities
{
    public interface IAnimal
    {
        int Hunger { get; }

        void Eat();

        void Spawn();

        string Satiety();
    }
}
