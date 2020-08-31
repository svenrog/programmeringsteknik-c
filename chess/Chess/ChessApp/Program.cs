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
            // multidimensinella arrayer
            // en siffra för varje ruta
            int[,] chessBoard = new int[8, 8];

            //svartvit bild
            int width = 128;
            int height = 128;
            byte[,] blackWhiteImage = new byte[width, height];

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    byte currentPixelValue = blackWhiteImage[x, y];
                }
            }

            int size = 128;
            byte[,,] voxelData = new byte[size, size, size];
            for (var z = 0; z < size; z++)
            {
                for (var y = 0; y < size; y++)
                {
                    for (var x = 0; x < size; x++)
                    {
                        byte currentVóxelValue = voxelData[x, y, z];
                    }
                }

            }

            // Uddasidiga (jagged) arrayer
            { int[][] jaggedArray = new int[3][]
           {
                    new int[] {1,3,5}, new int[] {}1,2,3,4}, new int[] { 1, 2, 3 }
                };
        
            Console.ReadKey();
        }
    }
}
