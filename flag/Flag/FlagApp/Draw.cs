using System;
using System.Collections.Generic;
using System.Text;

namespace FlagApp
{
    class Draw
    {
        public static void DrawFlag()
        {
            DrawMix();
            DrawSingle();
            DrawMix();
        }

        static void DrawMix()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 40; y++)
                {
                    if (y < 8)
                    {
                        DrawBlueBit();
                    }
                    else if (y > 10 && y < 17)
                    {
                        DrawYellowBit();
                    }
                    else
                    {
                        DrawBlueBit();
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawSingle()
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 40; y++)
                {
                    if (y < 40)
                    {
                        DrawYellowBit();
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawBlueBit()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("░░");
        }

        static void DrawYellowBit()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("░░");
        }

    }
}
