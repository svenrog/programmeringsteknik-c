using System;
using System.Collections.Generic;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //skriv en konsolapplikation som tar emot en skriven text
            //Antal ord som finns i texten, antal vokaler, vilket är det längsta ordet i texten
            //Word count
            //Vowel count
            //Longest word
            //char vowels = new char[] {'a', 'e', 'i', 'o','u','y','å','ä','ö'}
            //string test = "this is a test"
            //foreach (character in test){
            //
            //}

            Console.WriteLine("Write a text: ");
            string myText = Console.ReadLine();
            string myTextToLower = myText.ToLower();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            string 
            int wordCounter = 0;

            foreach (var word in myTextToLower)
            {
                Console.WriteLine(word);
                wordCounter++;
            }
        }
    }
}
