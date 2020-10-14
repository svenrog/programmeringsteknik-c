using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
        private char[] _vowels;

        public char[] Vowels { get; set; }

        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar bort vokaler (konstigt va?) från en inmatad sträng.
            // Applikationen skall både presentera den resulterande strängen och antalet vokaler som togs bort.

            char[] vowels = new char[] { 'a', 'e', 'o', 'i', 'u', 'y', 'å', 'ä', 'ö' };

            Console.Write("Skriv en sträng: ");
            var input = Console.ReadLine();
            var output = new List<char>();
            int removedCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i];
                var normalizedCharacter = char.ToLower(currentCharacter);

                if (vowels.Contains(normalizedCharacter) != true)
                {
                    output.Add(currentCharacter);
                }
                else
                {
                    removedCount++;
                }
            }

            var resultingString = new string(output.ToArray());
            
            Console.WriteLine($"Din sträng utan vokaler: '{resultingString}', vi tog bort: {removedCount} st.");
        }
    }
}
