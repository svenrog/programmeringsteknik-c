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

            //  Använda färg?
            
            static void DrawFlag()
            {
                for (var y = 0; y < 10; y++)
                {
                    Console.WriteLine();
                    for (var x = 0; x < 16; x++)
                    {
                        if (y == 4 || y == 5)
                        {
                            Console.Write("░░");
                            continue;
                        }
                        
                        if (x == 5 || x == 6)
                        {
                            Console.Write("░░");
                            continue;
                        }
                        Console.Write("▓▓");
                    }
                }
            }

            DrawFlag();
            Console.ReadLine();
        }
    }
}
