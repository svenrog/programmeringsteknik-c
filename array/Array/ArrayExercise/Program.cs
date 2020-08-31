using System;
using System.Linq;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 2, 3, 4 }; //{} - initieringsuttryck, du skapar de första värdena redan i skapandet

            // array.Length Visar hur stor arrayen är, dvs hur många poster.
            int arrayLenght = array.Length;

            // Första indexplatsen är alltid 0, en array med fyra indexplatser hämtar data från 0-3
            int firstPosition = array[0];

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

            // Se om arrayen innehåller ett värde med .Contains. Enklare och snyggare än att göra en for-loop med if-sats
            vowels.Contains('å');

            // Kommando i arrays för att hitta vailken indexplats värdet (å) finns på - Array
            // -1 om det givna värdet inte finns
            int vowelIndex = Array.IndexOf(vowels, 'å');

            // Ovan (Array.IndexOf) är samma som detta, det som skiljer är att man får tillbaka den sista positionen
            int vowelIndexFromLoop = -1;
            for (int i = 0; i < vowels.Length; i++) //break; continue;
            {
                var currentVowel = vowels[i];
                if (currentVowel == 'å')
                {
                    vowelIndexFromLoop = currentVowel;
                    break;
                }

                // Man bör skriva så här

                vowelIndexFromLoop = -1;
                for (int i = 0; i < vowels.Length; i++) //break; continue;
                {
                    currentVowel = vowels[i];
                    if (currentVowel == 'å')
                        continue;

                    vowelIndexFromLoop = currentVowel;
                    break;

                }
                // Går att göra samma sak med tex språk-koder
                static int GetSupportedLanguageIndex(string language)
                    {
                    string[] supportedLanguages = new string[] { "sv", "no", "dk" };
                    

                    for (int i = 0; i < supportedLanguages.Length; i++)
                    {
                        var currentLanguge = supportedLanguages[i];
                        if (currentLanguge == language)
                            return i;

                    }
                    return -1;
                }


            }
        }
    }
}
