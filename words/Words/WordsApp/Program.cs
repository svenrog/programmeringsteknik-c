using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //skriv en konsolapplikation som tar emot en text //readline
            //Antal ord som finns i texten //lista, antal vokaler //char , vilket är det längsta ordet i texten //.length
            //foreach (character in test)


            //My solution
            Console.WriteLine("Please write a sentence: ");

            string sentence = Console.ReadLine();
            string sentenceToLower = sentence.ToLower();
            
            int wordCounter = 0;
            int vowelsCounter = 0;

            //Counting words
            char[] split = { ' ', '.', ',', '!', '?', ':', ';' };
            foreach (var word in sentence.Split(split, StringSplitOptions.RemoveEmptyEntries))
            {
                wordCounter++;
            }

            //Counting vowels
            for(int i = 0; i < sentenceToLower.Length; i++)
            {
                if(sentenceToLower[i] == 'a' || sentenceToLower[i] == 'e' || sentenceToLower[i] == 'i'
                    || sentenceToLower[i] == 'o' || sentenceToLower[i] == 'u' || sentenceToLower[i] == 'y'
                        || sentenceToLower[i] == 'å' || sentenceToLower[i] == 'ä' || sentenceToLower[i] == 'ö')
                {
                    vowelsCounter++;
                }

            }

            //Looking for the longest word
            string[] wordsInSentence = sentence.Split(' ');
            string longestWord = wordsInSentence.OrderByDescending(i => i.Length).First();

            Console.WriteLine($"There is {wordCounter} words in the sentence, it contains {vowelsCounter} vowels");
            Console.WriteLine($"and the longest word is: {longestWord}!");
        }
    }
}
