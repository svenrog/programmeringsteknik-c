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
            char[] vowels = new char[] { 'a','A','e','E', 'i','I', 'o','O', 'u','U', 'y','Y', 'å','Å', 'ä','Ä', 'ö','Ö' };

            Console.Write("Please write a sentence: ");
            string sentence = Console.ReadLine();
            var output = new List<char>();
            int removedCount = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                var currentCharacter = sentence[i];
                var normaliZedCharacter = char.ToLower(currentCharacter);

                if(vowels.Contains(normaliZedCharacter) == false)
                {
                    output.Add(currentCharacter);
                }
                else
                {
                    removedCount++;
                }
            }

            var resultingString = new string(output.ToArray());



            Console.WriteLine($"Your sentence without vowels '{resultingString}', removed {removedCount} vowels.");
            Console.ReadKey();



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
