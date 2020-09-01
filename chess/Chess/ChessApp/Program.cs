using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rita ett schackbräde med hjälp av dessa två tecken ░ ▓.
            // Använd gärna metoder för att lösa problemet.
            // Man behöver använda % (modulo)

            static void Draw()
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        int rest = (x / 2 + y) % 2;
                        if (rest == 0)
                        {
                            Console.Write("░░");
                        }
                        else
                        {
                            Console.Write("▓▓");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Draw();
        }
    }
}
