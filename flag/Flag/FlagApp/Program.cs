using System;

namespace FlagApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates for-loop to iterate through the Y axis of the flag
            for (int y = 0; y < 8; y++)
            {
                // Creates for-loop to iterate through the X axis of the flag
                for (int x = 0; x < 20; x++)
                {
                    // Check if the Y-axis is on line 3 or 4
                    if (y == 3 || y == 4)
                    {
                        // Make it skip the last 4 spaces on this line because it makes 4 too many for some reason
                        if (x > 15)
                        {
                            continue;
                        }
                        // Changes the backgroundcolour to yellow and types out the character '▓'
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        System.Console.Write("▓");
                    }
                    // Checks if the X axis is on space 9. Without this the console continues making yellow.
                    else if (x / 9 % 2 == 1)
                    {
                        // Changes the backgroundcolour to blue and types out the character '░'
                        Console.BackgroundColor = ConsoleColor.Blue;
                        System.Console.Write("░");
                    }
                    // Checks if the X axis is on space 6, 7 or 8
                    else if (x / 6 % 6 == 1 || x / 7 % 7 == 1 || x / 8 % 8 == 1)
                    {
                        // Changes the backgroundcolour to yellow and types out the character '▓'
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        System.Console.Write("▓");
                    }
                    // Catches all of the remaining spaces on the X axis
                    else
                        // Changes the backgroundcolour to blue and types out the character '░'
                        Console.BackgroundColor = ConsoleColor.Blue;
                    System.Console.Write("░");

                }
                // Makes the text break into another line after every change in Y axis
                Console.Write("\n");
            }
            // Change the background color back to black after the flag is created just because
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
