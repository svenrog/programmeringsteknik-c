using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            Console.WriteLine("Skriv valfri text: ");
            string userText = Console.ReadLine();
            string lowercaseString = userText.ToLower();

            string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            int wordCount = words.Length;
            string longestWord = string.Empty;

            foreach(var word in words)
            {
                foreach (var character in word)
                {
                    if(vowels.Contains(character))
                    {
                        vowelCount++;
                    }
                }

                if (word.Length > longestWord.Length) 
                {
                        longestWord = word;
                }
            }

            Console.WriteLine("Texten är " + userText.Length + " tecken lång.");
            Console.WriteLine("Antal vokaler är: " + vowelCount);
            Console.WriteLine("Längsta ordet är: " + longestWord);


            Console.ReadKey();

        }
    }
}
