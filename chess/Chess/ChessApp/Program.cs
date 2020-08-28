using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //░ och ▓)
            int j = 0;
            for (var i = 0; i < 64; i++)
            {
                if(i % 8 == 0)
                {
                    Console.WriteLine("");
                    j++;
                }
                if (i % 2 == 0)
                {
                    if(j % 2 == 1)
                    {
                        Console.Write("▓▓");
                        continue;
                    }
                    Console.Write("░░");
                } else if(i % 2 == 1 && j % 2 == 0)
                {
                    Console.Write("▓▓");
                } else
                {
                    Console.Write("░░");
                }
            }
            Console.ReadLine();
        }
    }
}
