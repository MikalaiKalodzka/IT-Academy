using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Lecture_2_3_Kalodzka_Mikalai.Entities;

namespace Lecture_2_3_Kalodzka_Mikalai.Nature
{
    public class Field
    {
        private Random randomGenerator = new Random();

        private List<Rabbit> rabbits = new List<Rabbit>();
        private List<Tiger> tigers = new List<Tiger>();

        public ReadOnlyCollection<Rabbit> Rabbits { get { return new ReadOnlyCollection<Rabbit>(rabbits);  } } 

        public ReadOnlyCollection<Tiger> Tigers { get { return new ReadOnlyCollection<Tiger>(tigers); } } 

        public int Grass { get; private set; }

        public Field()
        {
            Grass = 10000000;
            rabbits = GenerateRabbits();
            tigers = GenerateTigers();
        }
        
        // TODO Not USED
        public void EatGrass()
        {
            if (Grass > 0)
                Grass--;
        }

        // TODO Метод иммет место быть, вот только не должны тигры из себя его вызывать...
        public void EatRabbit()
        {
            if (rabbits.Count > 0)
            {
                rabbits.RemoveAt(0);               
            }
            else if (rabbits.Count == 0)
                Console.WriteLine("There are no rabbits left.");
        }

        public void RabbitSpawn()
        {
            if (rabbits.Count > 1)
                rabbits.Add(new Rabbit(this));
        }

        public void TigerSpawn()
        {
            if (rabbits.Count > 1)
                tigers.Add(new Tiger(this));                
        }

        public List<string> GetListRabbits()
        {
            var rabbitList = new List<string>();
            foreach(var rabbit in rabbits)
            {
                if (rabbit != null)
                    rabbitList.Add(rabbit.ToString());                    
            }
            return rabbitList;
        }

        public List<string> GetListTigers()
        {
            var tigerList = new List<string>();
            foreach (var tiger in tigers)
            {
                if (tiger != null)
                    tigerList.Add(tiger.ToString());
            }
            return tigerList;
        }

        private List<Rabbit> GenerateRabbits()
        {
            var rabbits = new List<Rabbit>();
            var numberOfRabbits = randomGenerator.Next(10);
            for (int i = 0; i < numberOfRabbits; i++)
            {
                rabbits.Add(new Rabbit(this));
            }
            return rabbits;
        }

        private List<Tiger> GenerateTigers()
        {
            var tigers = new List<Tiger>();
            var numberOfRabbits = randomGenerator.Next(4);
            for (int i = 0; i < numberOfRabbits; i++)
            {
                tigers.Add(new Tiger(this));
            }
            return tigers;
        }
    }
}
