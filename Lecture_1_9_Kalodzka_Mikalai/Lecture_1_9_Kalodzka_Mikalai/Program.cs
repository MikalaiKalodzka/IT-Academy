using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Lecture_1_9_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Предсказание будущего.");
            

            bool finish = false;

            do
            {
                Console.WriteLine("Если вы хотите узнать предсказание на сегодня - введите '1'.\n" +
                    "Если вы хотите узнать предсказание на завтра - введите '2'.\n" +
                    "Если вы хотите узнать предсказание на следующую неделю - введите '3'.\n" +
                    "Если хотите узнать предсказание на следующий месяц - введите '4'.\n" +
                    "Если вы хотите оставаться в слепом неведении - введите '5'.\n");
                string command = Console.ReadLine();
                int commandValue;
                if (int.TryParse(command, out commandValue))
                {
                    
                    if (commandValue == 5)
                        finish = true;
                    else if (commandValue >= 1 && commandValue <= 4)
                    {
                        var prediction = new Prophecy((Interval)commandValue);
                        Console.WriteLine(prediction.Text);
                        Console.WriteLine();
                    }
                }
              
            } while (!finish);

            Console.ReadKey();
        }

    }
}

