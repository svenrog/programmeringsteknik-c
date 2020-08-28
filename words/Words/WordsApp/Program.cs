using System;
using System.Linq;
using System.Xml.Schema;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en konsolapp som tar emot en skriven text
            //Vi vill ha ut:
            //Antalet ord
            //Antalet vokaler
            //Vilket ord är längst

            //Word count
            //Vowel count
            //Longest word

            Console.WriteLine("Please enter a sentence or more.");
            string input = " " + Console.ReadLine();
            //Console.WriteLine(input);

            //Steg ett är att hitta all "whitespace"; mellanslag, för att se hur många olika ord som finns.
            int[] whitespace = new int[input.Length];
            for (int i = input.Length; i>0; i--)
            {
                if (input.Substring((i-1),1) == " ") 
                {
                    whitespace[(i-1)] = 1;
                }
                else 
                    whitespace[(i-1)] = 0;
            }
            
            
            /*for (int i = input.Length; i > 0; i--)
            {
                Console.WriteLine(whitespace[(i - 1)]);
            }*/


            //Nu har vi en lista i en array. Alla ettor är mellanslag/whitespace, medan nollor är andra tecken.
            int wordcount = 0;
            for (int i = input.Length; i > 0; i--)
            {
                if (whitespace[(i-1)] == 1)
                {
                    wordcount++;
                }
            }
            if (input.Length == 0) Console.WriteLine("The word count is zero.");
            else Console.WriteLine("The word count is " + wordcount);


            char[] vowels = { 'a', 'o', 'i', 'u', 'y', 'å', 'ä', 'ö', 'e'};
            int check = 0;
            int vowelCount = 0;
            for (int i = input.Length; i > 0; i--)
            {
                for (int n = 0; n<9; n++)
                {
                    check = vowels[n].CompareTo(Convert.ToChar(input.Substring((i-1),1)));      //ComparesTo ger ett värde som inte är noll om det inte är samma.
                    if (check == 0)
                    {
                        vowelCount++;
                    }
                }
            }
            Console.WriteLine("The vowel count is: " + vowelCount);


            //genom att räkna hur många nollor i rad som är mest så kan vi se vilket ord som är längst i vår 'whitespace' array.
            //alternativt kan vi leta efter största hålet mellan whitespaces i 'input'
            int charCounter = 0;
            int positionIndex = 0;
            int currentLargest = 0;
            int ticker = 0;
            foreach (int i in whitespace)
            {
                if (whitespace[ticker] == 0)
                {
                    charCounter++;
                }
                else 
                {
                    if (charCounter > currentLargest)
                    {
                        currentLargest = Math.Max(charCounter, currentLargest);
                        charCounter = 0;
                        positionIndex = ticker - currentLargest;
                    }
                    else {
                        charCounter = 0;
                    }
                }
                ticker++;
                
            }
            Console.WriteLine("The largest word is \'" + input.Substring(positionIndex, currentLargest) + "\' at " + currentLargest + " characters");

        }
    }
}
