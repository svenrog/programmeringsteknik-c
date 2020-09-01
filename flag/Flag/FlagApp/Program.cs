using System;

namespace FlagApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en applikation som ritar ut svenska flaggan
            // Använd metoder för att göra utritningen generell

            static void DrawMix()
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 30; y++)
                    {                        
                        if (y < 10)
                        {
                            Console.Write("-░░-");
                        }
                        else if (y > 10 && y < 16)
                        {
                            Console.Write("-▓▓-");
                        }
                        else
                        {
                            Console.Write("-░░-");
                        }
                    }
                    Console.WriteLine();
                }
            }

            static void DrawSingle()
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 30; y++)
                    {
                        if (y < 30)
                        {
                            Console.Write("-▓▓-");
                        }
                    }
                    Console.WriteLine();
                }
            }
            DrawMix();
            DrawSingle();
            DrawMix();
        }
    }
}
