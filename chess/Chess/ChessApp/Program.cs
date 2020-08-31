using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //rita ut schackbräde (8x8 = 64 rutor) med ascii - tecken (░▓)
            //med console write/console writeline
            //for i for-loop


            //My solution
            string oddNumber = "░░▓▓";
            
            string evenNumber = "▓▓░░";

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (y % 2 == 1)
                    {
                        Console.Write(oddNumber);
                    }
                    else
                    {
                        Console.Write(evenNumber);
                    }
                }
              Console.Write('\n');
            }


        }
    }
}
