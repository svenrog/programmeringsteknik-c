using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            int countVowels = 0;
            string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int countWords = inputArray.Length;
            char[] vowels = new char[] {'a', 'o', 'e', 'u', 'y', 'å', 'ä', 'ö', 'i'};

            foreach (char character in input)
            {
                if (vowels.Contains(character)) countVowels++;
            }

            string longestWord = "";
            int longestWordLength = 0;

            for (int i = 0 ; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > longestWordLength)
                {
                    longestWordLength = inputArray[i].Length;
                    longestWord = inputArray[i];
                }
            }
            Console.WriteLine($"Strängen innehållder {countWords} ord");
            Console.WriteLine($"Strängen innehållder {countVowels} vokaler");
            Console.WriteLine($"Längsta ord är -  {longestWord}");
        }
    }
}
