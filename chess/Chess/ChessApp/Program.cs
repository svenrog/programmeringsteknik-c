using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //rita ut chakbräde (8x8 = 64 rutor) med ascii - tecken (░▓)
            //med console write/console writeline
            //for i for-loop
            Console.WriteLine("░▓");

            for (int y = 0; y < 8; y++)
            {

                if (int x = 0; x % 2 == 0)
                {

                    Console.Write("░░");

                }
                else
                {
                    Console.Write("▓▓");
                }

                if (y == 8; int x = 0; x++)
                {
                     Console.Write("\n");
                }

            }

        }
    }
}
