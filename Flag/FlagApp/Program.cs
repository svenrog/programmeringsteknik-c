using System;

namespace FlagApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Skapa en applikation som ritar ut svenska flaggan
            // Använd metoder för att göra utritningen generell

            Console.Title = "Svenska flaggan";

            YellowAndBlue();
            SweFlagYellow();
            YellowAndBlue();

            Console.WriteLine("\nPress any key to quit program...");
            Console.ReadKey(true);
        }
        static void YellowAndBlue()
        {
            char charYellow = '▓';
            char charBlue = '░';

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            int intRenderingIndex = 0;
            bool boolRenderingStop = true;

            do

                for (var x = 0; x < 1; x++)
                {
                    for (var y = 0; y < 27; y++)
                    {
                        Console.Write(charYellow);
                    }
                    for (var y = 27; y < 37; y++)
                    {
                        Console.Write(charBlue);
                    }
                    for (var y = 38; y < 82; y++)
                    {
                        Console.Write(charYellow);
                    }

                    Console.Write('\n');
                    intRenderingIndex++;

                    if (intRenderingIndex == 9)
                    {
                        boolRenderingStop = false;
                    }

                } while (boolRenderingStop);
        }
        static void SweFlagYellow()
        {

            char charBlue = '░';

            for (var x = 0; x < 4; x++)
            {
                for (var y = 0; y < 81; y++)
                {
                    Console.Write(charBlue);
                }
                Console.Write('\n');
            }
        }
    }
}
