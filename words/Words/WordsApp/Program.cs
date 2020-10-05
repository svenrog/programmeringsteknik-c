using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsollapplikation som tar emot en skriven text.
            // Ha med antal ord
            // Antal vokaler
            // Vilket det längsta ordet är
            
            // Declares a char array containing all of the vowels in the swedish alphabet
            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            // Writes out text in the console that promts the user to input a sentence
            Console.WriteLine("Insert a sentence");
            // Stores inputted string into a string variable.
            string userInput = Console.ReadLine();
            // Modifies the string so that it is lowercase
            string myLowerCaseString = userInput.ToLower();
            // Declares a string array variable and uses the .Split method on the modified string to 
            // split each word in the sentence into the array. 
            // It also removes empty entries with 'StringSplitOptions.RemoveEmptyEntries'
            string[] words = myLowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // Declares a int variable and sets it to the length of the string array we just made
            int wordcount = words.Length;
            // Declares another int variable to store the number of vowels detected
            int vowelCount = 0;
            // Declares a string variable to store the longest word. Sets it to empty with the string.empty method
            string longestWord = string.Empty;
            
            // Creates a foreach loop inside of another foreach loop in order to go through each word in the string array
            // and check every character in each word for a match with the char array containing the vowles
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    // Creates an if statement to check if the character that is being checked is a vowel
                    if (vowels.Contains(character))
                    {
                        // If it is increase the vowelcount variable with +1
                        vowelCount++;
                    }
                    // Creates a seperate if statement that check if the current word is longer than the current longest word
                    if (word.Length > longestWord.Length)
                    {
                        // If it is replace the current word with the previous longest word
                        longestWord = word;
                    }
                }
            }
            
            // Types out the data to the console
            Console.WriteLine("Longest word: " + longestWord);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine("Word count: " + wordcount);
        }
    }
}