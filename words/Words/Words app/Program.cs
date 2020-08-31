using System;

namespace Words_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar emot en skriven text
            // Vi vill ha ut följande:
            // - Antal ord
            // - Antal vokaler
            // - Vilket det längsta ordet är

            // Word count
            // Vowel count
            // Longest word

           

            Console.WriteLine("Skriv en mening av ord: ");
            
           

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            string enteredString = Console.ReadLine();
            string lowercaseString = enteredString.ToLower();

            string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            int wordCount = 0;
            string longestWord = string.Empty;

            foreach (var word in words)
            {
                foreach (var character in word)
                { 

                    if (word.Contains(character))
                    {
                        vowelCount++;
                        
                    }

                for (var i = 0; i < words.Length; i++)
                {

                }
        }
        
    }
}
