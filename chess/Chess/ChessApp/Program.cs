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
                    int characterIndex = (x / 2 + y) % 2;
                    char character = characterIndex == 0 ? '░' : '▓';

                    Console.Write(character);
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            #region My try
            //for (int i = 0; i < 8; i++)
            //{
            //    int intLinebreake = i % 8;
            //    int intTest = i % 2;
            //    int intLineswitch = 1;

            //    if (intLineswitch % 2 == 1)
            //    {
            //        intLineswitch++;

            //        if (intTest == 1)
            //        {
            //            Console.Write("░");
            //        }
            //        else
            //        {
            //            Console.Write("▓");
            //        }
            //    }
            //    if (intLineswitch % 2 == 1)
            //    {
            //        if (intLineswitch % 2 == 1)
            //        {
            //            intLineswitch++;

            //            if (intTest == 1)
            //            {
            //                Console.Write("░");
            //            }
            //            else
            //            {
            //                Console.Write("▓");
            //            }
            //            intLineswitch++;

            //            if (intTest == 1)
            //            {
            //                Console.Write("░");
            //            }
            //            else
            //            {
            //                Console.Write("▓");
            //            }

            //        }



            //        Console.ReadKey(true);

            #endregion
            //-----------------------------------------------------------------------------------------

            // Lösning!

            // Rita ett schackbräde med hjälp av dessa två tecken
            // Använd gärna metoder
            // %% använd (modulus)

            Console.Title = "Chessboard";
            ChessBoard();
            Console.ReadKey(true);
        }
    }
}
