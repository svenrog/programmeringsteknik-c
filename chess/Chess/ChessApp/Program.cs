using System;
using System.Collections.Concurrent;

namespace ChessApp
{
    class Program
    {
        static void PrintBlackWhiteRow(int index, int rowLenght)
        {
            char white = '░';
            char black = '▓';

            //Prints out row
            for (int j = 0; j < rowLenght; j++)
            {
                //Variate rowpattern
                if ((index % 2) == 0)
                    Console.Write($"{black}{white}");
                else
                    Console.Write($"{white}{black}");
            }

        }
        static void Main(string[] args)
        {
            int boardLenght = 8; //Decides lenght of both row and lines
            //Print chessboard
            try
            {   
                for (int i = 0; i < boardLenght; i++)
                {
                    PrintBlackWhiteRow(i, boardLenght);
                    Console.WriteLine(); //Print new line
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); Console.ReadKey();
                throw;
            }

            //Terminate program
            Console.ReadKey();
        }
    }
}
