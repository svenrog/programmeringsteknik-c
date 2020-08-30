using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] signArray = new char[] {'░', '▓' };
            for(int i = 0; i < 4; i++)
            {
                for (int y = 0; y< 8; y++)
                {
                    int signIndex = y % 2;
                    RenderSign(signArray, signIndex);
                }
                Console.Write("\n");
                for (int y = 1; y < 9; y++)
                {
                    int signIndex = y % 2;
                    RenderSign(signArray, signIndex);
                }
                Console.Write("\n");
            }
            static void RenderSign(char[] signArray, int index)
            {
                for (int i = 0; i<2; i++) Console.Write(signArray[index]);
            }
        }
    }
}
