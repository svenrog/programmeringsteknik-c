using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence that's not offensive: ");

            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            string enteredString = Console.ReadLine();
            string lowercaseString = enteredString.ToLower();

            string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            int wordCount = words.Length;
            string longestWord = string.Empty;

            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        vowelCount++;
                    }
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            for (var i = 0; i < enteredString.Length; i++)
            {
                var character = enteredString[i];
            }

            // Antal ord?
            // Antal vokaler?
            // Vilket är det längsta ordet?
            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine("Longest word: " + longestWord + ", " + longestWord.Length + " characters.");
        }
    }
}
