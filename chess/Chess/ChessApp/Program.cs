using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //64 + 8 Line skips = 72 
            
            for (int i = 1; i < 72; i++)
            {
                //Even number
                if (i % 2 == 0)
                {
                    if (i % 9 == 0)
                    {
                        AddNewLine();
                    }
                    else
                    {
                        PaintWhite();
                    }

                }
                //Odd number
                else
                {
                    if (i % 9 == 0)
                    {
                        AddNewLine();
                    }
                    else
                    {
                        PaintBlack();
                    }
                }
            }
            Console.ReadLine();
        }
        static void PaintWhite()
        {
            Console.Write("▓▓");
        }

        static void PaintBlack()
        {
            Console.Write("░░");
        }

        static void AddNewLine()
        {
            Console.WriteLine("");
        }
    }
}
