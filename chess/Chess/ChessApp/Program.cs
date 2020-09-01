
            // Rita ett schackbräde med hjälp av dessa två tecken ░ ▓.
            // Använd gärna metoder för att lösa problemet.
            // Man behöver använda % (modulo)

using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] SignArray = new char[] {'░', '▓' };
            for(int i = 0; i <= 4; i++)
            {
                for (int y = 0; y< 8; y++)
                {
                    int signIndex = y % 2;
                    RenderSign(SignArray[signIndex]);
                }
                Console.Write("\n");
                for (int y = 1; y < 9; y++)
                {
                    int signIndex = y % 2;
                    RenderSign(SignArray[signIndex]);
                }
                Console.Write("\n");
            }
        static void RenderSign(char sign)
            {
                Console.Write(sign);
                Console.Write(sign);
                Console.Write(sign);
            }
        }
    }
}
