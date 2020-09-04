using System;
using System.Runtime.InteropServices;

namespace FlagApp
{
    class Program
    {
        //Size field
        const byte bannerHeight = 10;
        const byte bannerWidth = 16;

        //Method for Finnish flag
        static void PrintBlueWhiteRow(int index)
        {
            for (int j = 0; j < bannerWidth; j++)
            {
                Console.BackgroundColor = (j > 5 && j < 10 || index > 2 && index < 5) ? ConsoleColor.Blue : ConsoleColor.White;
                Console.Write(" ");
            }
        }
        //Method for Swedish flag
        static void PrintBlueYellowRow(int index)
        {
            char patternForBlue = '░'; ;
            char patternForYellow = '▓';
            for (int j = 0; j < bannerWidth; j++)
            {
                if (j > 5 && j < 10 || index > 2 && index < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(patternForBlue);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(patternForYellow);
                }
            }
        }
        static void Main(string[] args)
        {
            // Skapa en applikation som ritar ut svenska flaggan
            // Använd metoder för att göra utritningen generell

            //Print Swedish flag, exesscive code but nice texture
            try
            {
                for (int i = 0; i < bannerHeight; i++)//Print new line
                {
                    PrintBlueYellowRow(i);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                throw;
            }
            Console.WriteLine();

            //Background color flag soumalainen, best code but Finish
            try
            {
                for (int i = 0; i < bannerHeight; i++)
                {
                    PrintBlueWhiteRow(i);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                throw;
            }

            Console.ReadLine();
        }
    }
}
