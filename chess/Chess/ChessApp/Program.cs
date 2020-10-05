﻿using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rita ett schackbräde med hjälp av dessa två tecken ░ ▓.
            // Använd gärna metoder för att lösa problemet.
            // Man behöver använda % (modulo)
            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    var characterIndex = (x / 2 + y) % 2;
                    var character = characterIndex == 0 ? '▓' : '░';
                    Console.Write(character);
                }
                Console.Write('\n');
            }

            #region Mitt Försök
            Console.WriteLine();
            Console.WriteLine("Mitt Försök");
            for (int i = 1; i < 65; i++)
            {
                int lineBreak = i % 8;
                int chess = i % 2;
                //int lineSwitch = 1;

                if (i % 2 == 1)
                {
                    if (lineBreak == 1)
                    {
                        Console.Write("\n");
                    }
                    if (chess == 1)
                    {
                        if (chess != 1)
                            Console.Write('▓');
                        else
                            Console.Write('░');
                    }
                    else
                    {
                        if (chess != 1)
                            Console.Write('▓');
                        else
                            Console.Write('░');
                    }
                }
                else
                {
                    if (lineBreak == 1)
                    {
                        Console.Write("\n");
                    }
                    if (chess == 1)
                    {
                        if (chess != 1)
                            Console.Write('▓');
                        else
                            Console.Write('░');
                    }
                    else
                    {
                        if (chess != 1)
                            Console.Write('▓');
                        else
                            Console.Write('░');
                    }
                }
            }
            #endregion
        }
    }
}

