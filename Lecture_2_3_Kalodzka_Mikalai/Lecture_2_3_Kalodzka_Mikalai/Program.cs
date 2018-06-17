using System;
using System.Linq;

using Lecture_2_3_Kalodzka_Mikalai.Nature;


namespace Lecture_2_3_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();

            var rabbits = field.Rabbits.ToList();

            foreach (var rabbit in rabbits)
            {
                rabbit.Eat();
                rabbit.Spawn();
            }

            var tigers = field.Tigers.ToList();
            foreach(var tiger in tigers)
            {
                tiger.Eat();
                tiger.Spawn();
            }
            
            Console.WriteLine(string.Join("\n", field.GetListRabbits()));

            Console.WriteLine(string.Join("\n", field.GetListTigers()));

            Console.ReadKey();
        }       
    }
}
