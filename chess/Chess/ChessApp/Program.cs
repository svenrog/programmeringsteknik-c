using System;
using System.Reflection.Metadata.Ecma335;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            //int boardRows;

            //for (x = 1; x <= 8; x++)
            //{
            //   if (x % 2==0) 
            //    {
            //        boardRows = 1;
            //    }
            //   else
            //    {
            //        boardRows = 0;
            //    }
            //    for (y = 1; y <= 8 ; y++)
            //    {
            //        if (y % 2 == boardRows)
            //        {
            //            Console.Write("▓");
            //        }
            //        else
            //        {
            //            Console.Write("░");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    int characterIndex = (x / 2 + y) % 2;
                    char character = characterIndex == 0 ? '▓': '░';

                    Console.Write(character);
                }

                Console.Write('\n');
            }
            Console.ReadKey();
        }
    }
}
