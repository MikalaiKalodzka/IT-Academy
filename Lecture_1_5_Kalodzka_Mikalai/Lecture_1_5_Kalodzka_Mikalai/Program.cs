using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture_1_5_Kalodzka_Mikalai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            // TODO CONST
            string messageString = "Московское время {0:hh:mm:ss}. Говорят, и показывают все телестанции страны. ";
            int startIndex = 0;
            int endIndex = 14;

            while (true)
            {
                // TODO Слишком много строк - Нужен StringBuilder. 
                string formattedMessage = string.Format(messageString, DateTime.Now);
                int messageLength = formattedMessage.Length;
                if (endIndex > startIndex)
                {
                    Console.WriteLine(formattedMessage.Substring(startIndex, endIndex - startIndex));
                }
                else
                {
                    string firstHalfString = formattedMessage.Substring(startIndex, messageLength - startIndex);
                    // TODO 0 и 15 не должны быть за хардкоданы. Я так понимаю это у вас Start Index и messageString.Length
                    string secondHalfString = formattedMessage.Substring(0, 15 - (messageLength - startIndex));
                    Console.WriteLine(firstHalfString + secondHalfString);
                }
                Thread.Sleep(100);
                Console.Clear();

                // TODO Элегантно.
                startIndex = (startIndex + 1) % messageLength;
                endIndex = (endIndex + 1) % messageLength;
            }
        }
    }
}
