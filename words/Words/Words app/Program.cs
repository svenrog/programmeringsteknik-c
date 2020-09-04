using System;

namespace Words_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar emot en skriven text
            // Vi vill ha ut följande:
            // - Antal ord
            // - Antal vokaler
            // - Vilket det längsta ordet är

            // Word count
            // Vowel count
            // Longest word



            Console.WriteLine("Skriv en mening av ord: ");

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            string enteredString = Console.ReadLine();
            string lowerCaseString = enteredString.ToLower();

            string[] words = lowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            int wordCount = 0;
            string longestWord = string.Empty;

            foreach (string word in words)
            {
                wordCount++;
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

            }
            
            foreach (char letter in lowerCaseString)
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        vowelCount++;
                    }
                }
            }
            Console.WriteLine($"Antal ord: {wordCount}");
            Console.WriteLine($"Antal vokaler: {vowelCount}");
            Console.WriteLine($"Längsta ordet är: {longestWord} som har {longestWord.Length} bokstäver.");

            Console.ReadKey();
        }
    }
}