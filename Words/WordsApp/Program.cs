using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string, pref a sentence. ");
            
            // antal ord, antal vokaler, längsta ordet

            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };
            string enteredString = Console.ReadLine();
            string lowerCaseString = enteredString.ToLower();

            string[] words = lowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;
            string longestWord = string.Empty;
            
            int vowelCount = 0;

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

            foreach (var character in lowerCaseString)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            for (var i = 0; i < enteredString.Length; i++)
            {
                var character = enteredString[i];
            }

            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine($"Longest word: {longestWord}, {longestWord.Length} characters");
        }
    }
}
