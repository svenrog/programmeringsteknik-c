using System;
using System.Collections.Concurrent;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char white = '░';
            char black = '▓';
            //Printing chessboard
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i % 2) == 0)
                        {
                            Console.Write(black);
                            Console.Write(white);
                        }
                        else
                        {
                            Console.Write(white);
                            Console.Write(black);
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                throw;
            }

            Console.WriteLine();
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (j > 5 && j < 10 || i > 2 && i < 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(white);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(black);
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                throw;
            }
            //Flag
            Console.WriteLine();
            //Background color flag soumalainen
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        Console.BackgroundColor = (j > 5 && j < 10 || i > 2 && i < 5) ? ConsoleColor.Blue : ConsoleColor.White;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                throw;
            }

        }
    }
}
