using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en konsolapplikation som tar emot en skriven text.

            // Vi vill ha ut följande:
            // Antal ord
            // Antal vokaler
            // Vilket är det längsta ordet?

            // Word count
            // Vocal count - done
            // Longest word

            Console.Write("Hello user, please enter some info to be stored and sorted: ");
            string input = Console.ReadLine();
            string inputToLower = input.ToLower();

            string[] words = inputToLower.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int wordsCount = 0;
            string longestWord = "";
            foreach (var el in words)
            {
                if (longestWord.Length < el.Length)
                {
                    longestWord = el;
                }
                wordsCount++;
            }

            char[] vocals = new[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            int vocalCount = 0;
            foreach (var el in inputToLower)
            {
                if (vocals.Contains(el))
                {
                    vocalCount++;
                }
            }
            Console.WriteLine($"There are: {wordsCount} words and {vocalCount} vocals in this string. The longest word is: {longestWord}");
        }
    }
}
