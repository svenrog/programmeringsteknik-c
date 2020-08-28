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

            foreach (char stirngChar in input)
            {
                if (vowels.Contains(stirngChar)) countVowels++;
            }

            int[] countLettersInWords = new int[inputArray.Length];
            for (int i = 0 ; i < inputArray.Length; i++)
            {
                countLettersInWords[i] = inputArray[i].Length;
            }

            int indexLongestWord = 0;
            int tmpIndex = 0;
            int longestWordLength = 0;

            foreach (int countLettersInWord in countLettersInWords)
            {
                foreach (int countLettersInWord2 in countLettersInWords)
                {
                    if (countLettersInWord > countLettersInWord2 & countLettersInWord > longestWordLength)
                    {
                        longestWordLength = countLettersInWord;
                        indexLongestWord = tmpIndex;
                    }
                }
                tmpIndex++;
            }
            Console.WriteLine($"Strängen innehållder {countWords} ord");
            Console.WriteLine($"Strängen innehållder {countVowels} vokaler");
            Console.WriteLine($"Längsta ord är -  {inputArray[indexLongestWord]}");
        }
    }
}
