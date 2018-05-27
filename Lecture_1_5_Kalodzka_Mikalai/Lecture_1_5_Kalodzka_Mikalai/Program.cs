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
            string messageString = "Московское время {0:hh:mm:ss}. Говорят, и показывают все телестанции страны. ";
            int startIndex = 0;
            int endIndex = 14;

            while (true)
            {
                string formattedMessage = string.Format(messageString, DateTime.Now);
                int messageLength = formattedMessage.Length;
                if (endIndex > startIndex)
                {
                    Console.WriteLine(formattedMessage.Substring(startIndex, endIndex - startIndex));
                }
                else
                {
                    string firstHalfString = formattedMessage.Substring(startIndex, messageLength - startIndex);
                    string secondHalfString = formattedMessage.Substring(0, 15 - (messageLength - startIndex));
                    Console.WriteLine(firstHalfString + secondHalfString);
                }
                Thread.Sleep(500);
                Console.Clear();

                startIndex = (startIndex + 1) % messageLength;
                endIndex = (endIndex + 1) % messageLength;
            }
        }
    }
}
