using System;
/**
* @author Edgar Runnman
* @edgar.runnman@gmail.com
* @date - 2020-09-01 
*/
namespace FlagOfSwedenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                BlueYellowLineRender();
            }
            for (int i = 0; i < 3; i++)
            {
                YellowLineRender();
            }
            for (int i = 0; i < 5; i++)
            {
                BlueYellowLineRender();
            }

        }

        static void BlueYellowLineRender()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" ");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
        }

        static void YellowLineRender()
        {

            for (int i = 0; i < 35; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");

        }
    }
}
