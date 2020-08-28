using System;

namespace ChessApp
{
    class Program
    {
        //░ och ▓
        static void Main(string[] args)
        {
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("This board was hardcoded.");
            
            string b = "░░";
            string w = "▓▓";

            string evenLine = "";
            string oddLine = "";
            for (int n = 0; n < 8; n++)
            {
                if (n % 2 == 0) {
                        //Console.Write(w); 
                    oddLine = String.Concat(oddLine, w);
                    evenLine = String.Concat(evenLine, b);
                }
                    
                else {
                   //Console.Write(b); 
                   oddLine = String.Concat(oddLine, b);
                    evenLine = String.Concat(evenLine, w);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(oddLine);
                Console.WriteLine(evenLine);
            }
            
            Console.WriteLine("This board was generated through looping if statements.");
        }
    }
}
