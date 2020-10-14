using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
        static char[] _vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', 'A', 'E', 'i', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            int counter = 0;
            foreach (char c in input)
            {
                if (!_vowels.Contains(c))
                {
                    output += c;
                    counter++;
                }
            }
            Console.WriteLine($"input string minus vowels:\n {output}\n{counter} vowels were removed.");
        }
    }
}
