
namespace Lecture_2_3_Kalodzka_Mikalai.Entities
{

    public abstract class Beast : IAnimal
    {
        public int Hunger { get; protected set;}
        
        public abstract void Eat();

        public string Satiety()
        {
            if (Hunger < 0)
                return "I will survive.";
            else
                return $"{this.GetType().Name} wants to eat.";
        }

        public abstract void Spawn();

        public override string ToString()
        {
            return $"{this.GetType().Name} - Hunger: {Hunger} - Satiery: {Satiety()}";
        }
    }
}
