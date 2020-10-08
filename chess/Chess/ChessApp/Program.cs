using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //░ och ▓)
            int j = 0;
            for (var i = 0; i < 64; i++)
            {
                if(i % 8 == 0)
                {
                    Console.WriteLine("");
                    j++;
                }
                if (i % 2 == 0)
                {
                    if(j % 2 == 1)
                    {
                        Console.Write("▓▓");
                        continue;
                    }
                    Console.Write("░░");
                } else if(i % 2 == 1 && j % 2 == 0)
                {
                    Console.Write("▓▓");
                } else
                {
                    Console.Write("░░");
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
