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
            //Console.WriteLine(white);

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
            Console.WriteLine();/*
            for (int i = 0; i < 8; i++)
            {
                if (i != 5 && i != 6)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j != 5 && j != 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(black);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(white);
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int k = 0; k < 8; k++)
                        Console.WriteLine(white);
                    for (int m = 0; m< 8; m++)
                        Console.WriteLine(white);
                }
                    
                
                Console.WriteLine();
            }
            Console.ReadLine();*/
        }
    }
}
