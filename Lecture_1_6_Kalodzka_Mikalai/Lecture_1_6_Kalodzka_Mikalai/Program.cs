using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static Dictionary<string, decimal> purchaseList = new Dictionary<string, decimal>()
        {
            {"Макароны", 2.67M},
            { "Молоко", 1.3M},
            { "Хлеб", 2.0M}
        };

        static void Main(string[] args)
        {
            bool finish = false;

            do
            {
                Console.WriteLine("Если вы хотите добавить покупку - введите '1'.\n" +
                    "Если вы хотите узнать цену товара - введите '2'.\n" +
                    "Если вы хотите вывести на экран товары дороже, чем ... - введите '3'.\n" +
                    "Если хотите выйти - введите '4'.");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        {
                            AddPurchase();
                            break;
                        }
                    case "2":
                        {
                            PriceSearch();
                            break;
                        }
                    case "3":
                        {
                            OutputGreaterThan();
                            break;
                        }
                    case "4":
                        {
                            finish = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Ввели неверное значение.");
                        break;
                }

            } while (!finish);

            Console.ReadKey();
        }

        static void AddPurchase()
        {
            Console.WriteLine("Введите название покупки: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите стоимость покупки: ");
            decimal price = decimal.Parse(Console.ReadLine());
            purchaseList[name] = price;
            string dictionaryValue = "Добавлено - Покупка: {0}  |  Стоимость: {1}";
            Console.WriteLine(string.Format(dictionaryValue, name, price));


        }

        static void PriceSearch()
        {
            Console.WriteLine("Введите, интерисующий вас товар: ");
            string userInput = Console.ReadLine();
            bool purchaseListSearch = purchaseList.ContainsKey(userInput);

            if (purchaseListSearch)
            {
                string searchResultPositive = "Стоимость товара {0} составляет {1}.";
                Console.WriteLine(string.Format(searchResultPositive, userInput, purchaseList[userInput]));
            }
            else Console.WriteLine("Ваш товар в списке покупок отсутствует.");

        }

        static void OutputGreaterThan()
        {
            Console.WriteLine("Введите стоимость: ");
            decimal price = decimal.Parse(Console.ReadLine());
            string priceCompare = "Товар {0} стоимостью {1} дороже, чем {2}.";
            int counter = 0;

            foreach (var purchase in purchaseList.Keys)
            {

                if (price < purchaseList[purchase])
                {
                    counter++;
                    Console.WriteLine(string.Format(priceCompare, purchase, purchaseList[purchase], price));
                }
                else continue;

            }


            string noProducts = "Нет товаров дороже {0}.";
            if (counter == 0)
                Console.WriteLine(string.Format(noProducts, price));
        }

    }
}