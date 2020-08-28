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

            foreach (var character in myString)
            {

                if (vowels.Contains(character)
                {
                    vowelsCount;

                }

                for (var i = 0; i < myString.Length; i++)
                {

                }
        }
        
    }
}
