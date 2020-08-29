using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsollapplikation som tar emot en skriven text.
            // Ha med antal ord
            // Antal vokaler
            // Vilket det längsta ordet är
            Console.WriteLine("Insert a sentence");
            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            string userInput = Console.ReadLine();
            string myLowerCaseString = userInput.ToLower();
            
            int wordcount = userInput.Length;

            string[] words = myLowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            string longestWord = string.Empty;
            
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        vowelCount++;
                    }
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            
            Console.WriteLine("Longest word: " + longestWord);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine("Word count: " + wordcount);
        }
    }
}