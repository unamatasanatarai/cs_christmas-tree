using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayCredits();
            int branches = GetBranchCount();
            bool decorations = GetDecorations();

            Random rnd = new Random();

            for (int level = 0; level < branches; level++)
            {
                for (int lSpacer = 0; lSpacer < branches - level; lSpacer++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < (2 * level + 1); star++)
                {
                    if (decorations)
                        Console.Write(rnd.Next(1, 10) < 8 ? "*" : "O");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }

        static int GetBranchCount()
        {
            string sCount;
            Int32 iCount;

            do
            {
                Console.WriteLine("Podaj ile gałęzi narysować.");
                sCount = Console.ReadLine();
            } while (!Int32.TryParse(sCount, out iCount));
            return iCount;
        }

        static bool GetDecorations()
        {
            ConsoleKeyInfo sAnswer;

            Console.WriteLine("Czy dodać bombki?");
            Console.WriteLine("1. Tak\n2. Nie");

            do
            {
                sAnswer = Console.ReadKey(true);
            } while (sAnswer.Key != ConsoleKey.D1 && sAnswer.Key != ConsoleKey.D2);

            Console.Clear();
            return sAnswer.Key == ConsoleKey.D1 ? true : false;
        }

        static void DisplayCredits()
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|  Algorytm rysujący Choinkę (z bombkami!)  |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|  .autor                                   |");
            Console.WriteLine("|  Piotr Grabowski                          |");
            Console.WriteLine("|                               05.11.2016  |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine();

        }
    }
}
