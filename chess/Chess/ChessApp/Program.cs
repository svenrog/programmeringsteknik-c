using System;
using System.Reflection.Metadata.Ecma335;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //░ och ▓)
            int currentRow = 0;
            for (var tilesNumber = 0; tilesNumber < 64; tilesNumber++)
            {
                if(tilesNumber % 8 == 0)
                {
                    Console.WriteLine("");
                    currentRow++;
                }
                if (tilesNumber % 2 == 0)
                {
                    if(currentRow % 2 == 1)
                    {
                        Console.Write("▓▓");
                        continue;
                    }
                    Console.Write("░░");
                } else if(tilesNumber % 2 == 1 && currentRow % 2 == 0)
                {
                    Console.Write("▓▓");
                } else
                {
                    Console.Write("░░");
                }
            }

            Console.WriteLine();

            //ny version, förenklad

            for (var height = 0; height < 8; height++)
            {
                Console.WriteLine();
                for (var width = 0; width < 8; width++)
                {
                    if (height % 2 == 0 && width % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write("  ");
                        continue;
                    }

                    if (width % 2 == 1 && height % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write("  ");
                        continue;
                    }
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                }
            }

            Console.ReadLine();
=======
            // Rita ett schackbräde med hjälp av dessa två tecken ░ ▓.
            // Använd gärna metoder för att lösa problemet.
            // Man behöver använda % (modulo)
>>>>>>> 4c0a63f21c15e580e41bad7e0d47b9e369ef1841
        }
    }
}
