using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project2021
{
    class Tools
    {
        public static int LoadNumber(string wiadomosc, int min, int max)
        {
            int liczba;

            do
            {
                Console.Write(wiadomosc);
                try
                {
                    string input = Console.ReadLine();
                    liczba = int.Parse(input);
                    if (SprawdzLiczbe(min, max, liczba) == true)
                    {
                        break;
                    }
                    else
                    {
                        WriteLineRed("A number out of range was provided.");
                    }
                }
                catch (FormatException)
                {
                    WriteLineRed("Wrong format specified. Enter an integer!");
                }
            }
            while (true);

            return liczba;
        }
        public static bool SprawdzLiczbe(int min, int max, int liczba)
        {
            bool czyDobra;
            if (min - 1 < liczba && liczba < max + 1) czyDobra = true;
            else czyDobra = false;
            return czyDobra;
        }
        public static void Dots(int kropki, int delay)
        {
            for (int i = 0; i < kropki; i++)
            {
                Console.Write(".");
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        public static void WriteLineRed(string t)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{t}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
            

    }
}
