using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar bort vokaler (konstigt va?) från en inmatad sträng.
            // Applikationen skall både presentera den resulterande strängen och antalet vokaler som togs bort.

            char[] charWovels = new char[] { 'a', 'o', 'u', 'i', 'e', 'å', 'ä', 'ö' }; // HashSet

            Console.WriteLine("skriv in lite text.");
            var input = Console.ReadLine().ToLower();
            var output = new List<char>();
            string[] words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int removedCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentCharacter = input[i];
                var normalizedCharacter = char.ToLower(currentCharacter);

                if (!charWovels.Contains(normalizedCharacter)/* != true, == false är samma sak.*/)
                {
                    output.Add(currentCharacter);
                }
                else
                {
                    removedCount++;
                }
            }
            var resultingString = new string(output.ToArray());

            Console.WriteLine($"Din sträng utan vokaler '{resultingString}', vi tog bort, {removedCount} st.");
        }
    }
}
