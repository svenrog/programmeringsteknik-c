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

            string[] words = userText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
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
            }

            Console.WriteLine("Texten är " + userText.Length + " tecken lång.");

            foreach(var character in userText)
            {
                if (vowels.Contains(character))
                {
                    Console.WriteLine("Texten innehåller: " + );

                }

                Console.WriteLine("Längsta ordet är: " + longestWord + "," +)
            }

            Console.ReadKey();

        }
    }
}
