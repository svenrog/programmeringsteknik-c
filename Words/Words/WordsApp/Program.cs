using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ut en konsolapplikation som tar emot en skriven text.

            // Antal ord
            // Antal vokaler
            // vilket är det längsta ordet

            // Word count
            // Vowel count
            // Longest word

            int intVowelCount = 0;
            int intWordCount = 0;
            char[] charVowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };
            string longestWord = string.Empty;

            Console.WriteLine("Write a sentence please.");
            string enteredString = Console.ReadLine();                        
            string lowercaseString = enteredString.ToLower();

            string[] words = enteredString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                foreach (var character in enteredString)
                {
                    if (charVowels.Contains(character));
                    {
                        intVowelCount++;
                    }
                }

                if (word.Length > longestWord.Length)
                {

                }
            }

            Console.WriteLine($"Word count is: {intWordCount}");
            Console.WriteLine($"Vowel count is: {intVowelCount}");
            Console.WriteLine($"Longest word is: {intWordCount}");

            Console.ReadLine();
        }
    }
}
