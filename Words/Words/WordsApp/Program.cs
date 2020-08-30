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

            Console.Title = "WordApp";
            Console.WriteLine("Write a sentence please.");
            string enteredString = Console.ReadLine();
            
            string lowerCaseString = enteredString.ToLower();
            string[] words = lowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string strLongestWord = string.Empty;

            char[] charVowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            int intWordCount = words.Length;
            int intVowelCount = 0;

            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (charVowels.Contains(character))
                    {
                        intVowelCount++;
                    }
                }

                if (word.Length > strLongestWord.Length)
                {
                    strLongestWord = word;
                }
            }

            Console.WriteLine($"\nThe amount of words are: {intWordCount}");
            Console.WriteLine($"The amount of vowels are: {intVowelCount}");
            Console.WriteLine($"The longest word is: {strLongestWord}");

            Console.WriteLine("\nPress any key to quit program...");
            Console.ReadKey(true);
        }
    }
}
