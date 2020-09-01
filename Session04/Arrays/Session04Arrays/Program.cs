using System;
using System.Linq;

namespace Session04Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1,2,3,4};

            //Antalet värden i arrayen
            int arrayLength = array.Length;
            
            //Komma åt data i arrayen, index är baserat på 0
            int firstPosition = array[0];

            char[] vowels = new char[] { 'a', 'e', 'o', 'u' };

            //Se om arrayen innehåller ett värde
            //Använda linq
            vowels.Contains('å');

            // Returnerar indexvärdet, om värdet är utanför array = -1
            int vowelIndex = Array.IndexOf(vowels, 'å');

            //Man kan istället göra såhär för att få identiskt resultat med Array.IndexOf
            int vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];

                if (currentVowel == 'å')
                {
                    vowelIndexFromLoop = i;
                    break;

                }
            }

            //Man bör skriva såhär
            vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];
                if (currentVowel != 'å')
                    continue;

                vowelIndexFromLoop = i;
                break;

            }

            // Går att göra samma sak med tex språk-koder
            string[] supportedLanguages = new string[] { "sv", "no", "dk" };
            int languageIndexFromLoop = -1;

            for (int i = 0; i < supportedLanguages.Length; i++)
            {
                var currentLanguage = supportedLanguages[i];
                if (currentLanguage != "sv")
                    continue;

                languageIndexFromLoop = i;
                break;

            }

        }

        static int GetSupportedLanguageIndex(string language)
        {

            string[] supportedLanguages = new string[] { "sv", "no", "dk" };

            for (int i = 0; i < supportedLanguages.Length; i++)
            {
                var currentLanguage = supportedLanguages[i];
                if (currentLanguage == language)
                    return i;

            }

            return -1;
        }
    }
}
