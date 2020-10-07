using System;

namespace MultipleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multidimensionella arrayer
            // en siffra för varje ruta
            int[,] chessBoard = new int[8, 8];

            // svartvit bild
            int width = 128;
            int height = 128;
            byte[,] blackWhiteImage = new byte[width, height];

            for (var y = 0; y < height; y++)
            {
                for (var x= 0; x < width; x++)
                {
                    byte currentPixelValue = blackWhiteImage[x, y];
                }
            }

            // tredimensionell data
            int size = 128;
            int[,,] voxelData = new int[size, size, size];

            for (var z = 0; z < size; z++)
            {
                for (var y = 0; y < size; y++)
                {
                    for (var x = 0; x < size; x++)
                    {
                        int currentVoxelValue = voxelData[x, y, z];
                    }
                }
            }

            // uddasidiga (jagged) arrayer
            int[][] jaggedArray = new int[3][]
            {
                new int[] {1,3,5}, new int[] {1,4,5}, new int[] {9,8,7,5,6}
            };
        }
    }
}
