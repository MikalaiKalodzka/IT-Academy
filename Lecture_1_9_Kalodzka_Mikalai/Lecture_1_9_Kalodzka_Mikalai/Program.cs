using System;
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
                int intervalCounter = 1;
                foreach (var name in Enum.GetNames(typeof(Interval)))
                {
                    // TODO ENUM могут иметь русские мена + у них есть возможность работы через description + метод расширения тоже хорош
                    Console.WriteLine("Если вы хотите узнать предсказание на {1} - введите '{0}'.", intervalCounter++, name);
                }

                Console.WriteLine("Если вы хотите узнать предсказание на сегодня - введите '1'.\n" +
                                  "Если вы хотите узнать предсказание на завтра - введите '2'.\n" +
                                  "Если вы хотите узнать предсказание на следующую неделю - введите '3'.\n" +
                                  "Если хотите узнать предсказание на следующий месяц - введите '4'.\n" +
                                  "Если вы хотите оставаться в слепом неведении - введите '5'.\n");
                string command = Console.ReadLine();
                int commandValue;
                if (int.TryParse(command, out commandValue))
                {
                    // TODO Работа с ENUM
                    var interval = (Interval) commandValue;

                    if (commandValue == 5)
                        finish = true;
                    else if (Enum.IsDefined(typeof(Interval), interval))
                    // TODO Тогда если измениться количество интервалов не надо будет переписывать иф 
                    // else if (commandValue >= 1 && commandValue <= 4)
                    {
                        var prediction = new Prophecy((Interval) commandValue);
                        Console.WriteLine(prediction.Text);
                        Console.WriteLine();
                    }
                }
            } while (!finish);

            Console.ReadKey();
        }
    }

    static class Ext
    {
        public static string ToRusString(this Interval interval)
        {
            switch (interval)
            {
                case Interval.Today:
                    return "Сегодня";
                case Interval.Tomorrow:
                    return "Завтра";
                case Interval.AfterWeek:
                    return "Через Неделю";
                case Interval.AfterMonth:
                    return "Через Месяц";
            }

            return string.Empty;
        }
    }
}