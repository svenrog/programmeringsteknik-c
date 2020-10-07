using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args) // Egen lösning
        {
            for(int columns = 0; columns < 8; columns++)
            {
                if (columns % 2 == 0 ? true : false)
                {
                    for (int rows = 0; rows < 8; rows++)
                    {
                        if (rows % 2 == 0 ? true : false)
                        {
                            Console.Write("░░");
                        }
                        else
                        {
                            Console.Write("▓▓");
                        }
                    }
                }

                else
                {
                    for (int rows = 0; rows < 8; rows++)
                    {
                        if (rows % 2 == 0 ? true : false)
                        {
                            Console.Write("▓▓");
                        }
                        else
                        {
                            Console.Write("░░");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
            Second();
        }

        public static void Second() // Gemensam lösning
        {
            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)
                {
                    var characterIndex = (x / 2 + y) % 2;
                    var character = characterIndex == 0 ? '░' : '▓';

                    Console.Write(character);
                }

                Console.WriteLine();
            }
        }
    }
}
