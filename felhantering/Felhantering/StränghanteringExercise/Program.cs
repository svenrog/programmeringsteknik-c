using System;

namespace StränghanteringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string inputData = "    ";

            //// kontrollera om strängen är tilldelad ett värde
            //bool inputIsNull = inputData == null;
            //bool inputIsEmpty = inputData == string.Empty; // InputData == "";

            //// snabbmetoder för att kontrollera innehållet i en sträng
            //bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            //// ytterligare kontroller om strängen innehåller vettig data
            //bool inpusIsNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);

            //string sentence = "   This is a sentence of text, it contains many words.    ";

            //// trimma bort mellanslag och andra whitespace-teckan från början till slut.
            //string trimmedSentence = sentence.Trim();
            //string endTrimmedSentence = sentence.TrimEnd();

            //// det går att ange ett speciellt tecken som ska trimmas bort
            //string punctationTrimmedSentence = endTrimmedSentence.TrimEnd('.');

            //string searchForWord = "text";
            //int indexOfText = trimmedSentence.IndexOf(searchForWord);

            //// Hämta bara området som letas efter
            //string hitSubstring = trimmedSentence.Substring(indexOfText, searchForWord.Length);
            //string beforeHitSubstring = trimmedSentence.Substring(0, indexOfText);

            //// små stora bokstäver
            //string uppercaseString = trimmedSentence.ToUpper();
            //string lowercaseString = trimmedSentence.ToLower();

            //// struntar i språkinställningar
            //string uppercaseInvariantString = trimmedSentence.ToUpperInvariant();

            //// komma åt ett enskilt tecken
            //char oneCharacter = trimmedSentence[0];

            //for (int i = 0; i < trimmedSentence.Length; i++)
            //{
            //    // loopa igenom en sträng, tecken för tecken
            //    char currentCharacter = trimmedSentence[i];
            //}

            //foreach (var currentCharacter in trimmedSentence)
            //{
            //    // loopa igenom en sträng, tecken för tecken
            //    // här har man inte ett index
            //}

            //char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            //// modifiera datat

            //trimmedSentence = new string(trimmedSentenceCharArray);

            //trimmedSentence = trimmedSentence + "...";
            //// samma som ovan
            //trimmedSentence += "...";

            //var numberInString = "12";
            //var paddedNumberInString = numberInString.PadLeft(3, '0');

            string word = "trollskog";
            int letterCount = word.Length;
            int letterCountAgain = 0;
            int letterCountFor = 0;
            Console.WriteLine(letterCount);

            
            foreach (var result in word)
            {
                letterCountAgain = letterCountAgain + 1;
            }
            Console.WriteLine(letterCountAgain);

            for (int i = 0; i < word.Length; i++)
            {
                letterCountFor = letterCountFor + 1;
            }
            Console.WriteLine(letterCountFor);
        }
    }
}
