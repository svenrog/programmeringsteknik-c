using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rita ett schackbräde med hjälp av dessa två tecken ░ ▓.
            // Använd gärna metoder för att lösa problemet.
            // Man behöver använda % (modulo)
            //Kommentar

            Console.WriteLine("Hi there, Please enter the desired size for your chessboard.");
            String answer = Console.ReadLine();
            
            chessBoard(Convert.ToInt32(answer));
            
            
        }


        static void chessBoard(int size)
        {
            int counter = 1;
            
            for (int x = 1; x <= size; x++)
            {

                for (int y = 1; y <= size; y++)
                {

                    if (counter % 2 == 0)
                    {
                        Console.Write("░░");
                    }
                    else
                    {
                        Console.Write("▓▓");
                    }

                    counter++;

                }
                Console.WriteLine();
                if(size%2 == 0)
                {
                    counter++;
                }
                
                

            }
        }
    }
}
