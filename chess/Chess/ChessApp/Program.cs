using System;

namespace ChessApp
{
    class Program
    {
        static void ChessBoard()
        {
            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    int intCharIndex = (x / 2 + y) % 2;
                    char charCharacter = intCharIndex == 0 ? '░' : '▓';

                    Console.Write(charCharacter);
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            
            // Lösning!

            // Rita ett schackbräde med hjälp av dessa två tecken
            // Använd gärna metoder
            // %% använd (modulus)

            Console.Title = "Chessboard";
            ChessBoard();
            //cb.Chessoard();
            Console.WriteLine("\nPress any key to quit program...");
            Console.ReadKey(true);
        }
    }
}
