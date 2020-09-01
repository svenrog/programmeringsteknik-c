using System;
using System.Security.Cryptography.X509Certificates;

namespace FlagApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en applikation som ritar ut svenska flaggan
            //Använd metoder för att göra utritningen generell

            //▓▓

            //░░

            //  Använda % 5,6 för mitten av flaggan??

            static void DrawFlag()
            {
                for (var height = 0; height < 10; height++)
                {
                    Console.WriteLine();
                    for (var length = 0; length < 16; length++)
                    {
                        if (height == 4 || height == 5)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("  ");
                            continue;
                        }
                        
                        if (length == 5 || length == 6)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("  ");
                            continue;
                        }
                        
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  ");
                    }
                }
            }

            DrawFlag();
            Console.ReadLine();
        }
    }
}
