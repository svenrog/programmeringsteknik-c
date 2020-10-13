using System;
using System.Collections.Generic;

namespace vowelapp
{
    class Program
    {
       static public char[] vowelsToRemove = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

        static void Main(string[] args)
        {
            
            // Skriv en konsolapplikation som tar bort vokaler (konstigt va?) från en inmatad sträng.
            Console.WriteLine("Mata in en text: ");
            string userInput = Console.ReadLine();

            int terminatedVowlCounter = 0;

            //string inputWithRemovedVowl =  userInput.Trim(vowelsToRemove);

            //terminatedVowlCounter = userInput.Length - inputWithRemovedVowl.Length;


           userInput = VowelRemover(userInput.ToCharArray(), out terminatedVowlCounter);
            //foreach (var input in userInput)
            //{
               
            //    if ()
            //    {

            //    }
            //}
            Console.ReadKey();

            // char[] charToRemoveFromString = userInput.ToCharArray();

            // charToRemoveFromString.Remove 




            // Applikationen skall både presentera den resulterande strängen och antalet vokaler som togs bort.
            Console.WriteLine("Sträng med borttagna vokaler: " + userInput);
            Console.WriteLine("Antal borttagna vokaler: " + terminatedVowlCounter);
            Console.ReadKey();
        }

        static string VowelRemover(char[] input, out int counter)
        {
            counter = 0;
            string truncatedInput = null ;

            List<char> output = new List<char>();
            
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var vowel in vowelsToRemove)
                {
                    var character = char.ToLower(input[i]);

                    if (character == vowel) counter++;  
                    else
                        output.Add(input[i]);
                    
                    
                }
                
            }
            truncatedInput = new string(output.ToArray());
            return truncatedInput;
        }
    }
}
