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
            /*
            for (int i = 1; i < 65; i++)
            {
                int lineBreak = i % 8;
                int test = i % 2;
                int lineSwitch = 0;

                if (lineSwitch % 2 == 1)
                {
                    if (lineBreak == 1)
                    {
                        Console.Write("\n");
                        lineSwitch++;
                    }
                    if (test == 1)
                        Console.Write('▓');
                    else
                        Console.Write('░');
                }
                else //if (lineSwitch % 2 == 1)
                {
                    if (lineBreak == 1)
                    {
                        Console.Write("\n");
                        lineSwitch++;
                    }
                    if (test == 0)
                        Console.Write('▓');
                    else
                        Console.Write('░');
                }
            }
            */
            #endregion
        }
    }
}

