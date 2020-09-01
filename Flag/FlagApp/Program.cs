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

            
            static void DrawFlag()
            {
                for (var y = 0; y < 4; y++)
                {
                    Console.WriteLine();
                    for (var x = 0; x < 16; x++)
                    {
                        if (x == 5 || x == 6)
                        {
                            Console.Write("░░");
                            continue;
                        }
                        Console.Write("▓▓");
                    }
                }
            }

            
            static void DrawMidFlag()
            {
                for (var y = 0; y < 2; y++)
                {
                    Console.WriteLine();
                    for (var x = 0; x < 16; x++)
                    {
                        Console.Write("░░");
                    }
                }
            }

            DrawFlag();
            DrawMidFlag();
            DrawFlag();
            Console.ReadLine();
        }
    }
}
