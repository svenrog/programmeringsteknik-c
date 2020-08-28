using System;
using System.Runtime.CompilerServices;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("░" + "▓" + "░" + "▓" + "░" + "▓" + "░" + "▓");
            //Console.WriteLine("▓" + "░" + "▓" + "░" + "▓" + "░" + "▓" + "░");
            //Console.WriteLine("░" + "▓" + "░" + "▓" + "░" + "▓" + "░" + "▓");
            //Console.WriteLine("▓" + "░" + "▓" + "░" + "▓" + "░" + "▓" + "░");
            //Console.WriteLine("░" + "▓" + "░" + "▓" + "░" + "▓" + "░" + "▓");
            //Console.WriteLine("▓" + "░" + "▓" + "░" + "▓" + "░" + "▓" + "░");
            //Console.WriteLine("░" + "▓" + "░" + "▓" + "░" + "▓" + "░" + "▓");
            //Console.WriteLine("▓" + "░" + "▓" + "░" + "▓" + "░" + "▓" + "░");

            //Console.ReadKey();

            //Rita ut ett chackbräde med ascii-tecken

            //string[] squareArray = new string[] { "▓", "░" };
            //for (int i = 0; i <= 4; i++)
            //{
            //    for (int y = 0; y < 8; y++)
            //    {
            //        int squareIndex = y % 2;
            //        RenderSquare(squareArray[squareIndex]);
            //    }
            //    Console.Write("\n");
            //    for (int y = 1; y < 9; y++)
            //    {
            //        int squareIndex = y % 2;
            //        RenderSquare(squareArray[squareIndex]);
            //    }
            //    Console.Write("\n");
            //}
            //static void RenderSquare(string square)
            //{
            //    Console.Write(square);
            //    Console.Write(square);
            //    Console.Write(square);
            // }

            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    int characterIndex = (x / 2 + y) % 2;
                    char character = characterIndex == 0 ? '▓' : '░';

                    Console.Write(character);
                }
                Console.Write('\n');
            }
            Console.ReadKey();
        }
    }
}
