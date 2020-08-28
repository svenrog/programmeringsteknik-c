using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en konsolapplikation som tar emot en skriven text.
            int wordCount;
            int vowelCount = 0;
            string longestWord;
            

            var vowel = new char[] { 'a', 'i', 'e', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            Console.WriteLine("Var vänlig och skriv in en text: ");
            //string input = Console.ReadLine();
            var inputStringArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);//new [] för FrameWork 

            //Vi vill ha ut följande:
            //Antal ord
            Console.WriteLine("Antal ord: " + inputStringArray.Length);
            //Antal vokaler
            foreach (var vowels in inputStringArray)
                foreach (var characters in vowel)
                    if (vowels.Contains(characters)) ++vowelCount;
            Console.WriteLine("Antal vokaler: " + vowelCount);
            //Vilket är det längsta ordet
            var sorted = inputStringArray.OrderBy(n => n.Length);
            longestWord = sorted.LastOrDefault();

            Console.WriteLine("Längsta ordet: " + inputStringArray.Max());
            Console.ReadKey();
        }
    }
}
