using System;
using System.Collections.Generic;
using System.Linq;

namespace vowelapp
{
    class Program
    {
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
        }
    }
}
