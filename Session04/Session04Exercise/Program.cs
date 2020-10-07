using System;

namespace Session04Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = "    ";

            //kontrollera om strängen är tilldelad ett värde
            bool inputIsNull = inputData == null;
            bool inputIsEmpty = inputData == string.Empty; // inputData == "";

            //  snabbmetoder för att kontrollera innehållet i en sträng
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            // ytterligare kontroller oms trängen innehåller vettig data
            bool inputIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(inputData);

            string sentence = "    This is a sentence of text, it contains many words.     ";

            // trimma bort mellanslag och andra whitespace-tecken från början och slutet. 
            string trimmedSentence = sentence.Trim();
            string endTrimmedSentence = sentence.TrimEnd();

            // det går att ange ett speciellt tecken som skall tas bort
            string punchtuationTrimmedSentence = endTrimmedSentence.TrimEnd('.');

            string searchForWord = "text";
            int indexOfText = trimmedSentence.IndexOf(searchForWord);

            // hämta bara området som letas efter
            string subString = trimmedSentence.Substring(0,4);
            string hitSubstring = trimmedSentence.Substring(indexOfText, searchForWord.Length);
            string beforeHitSubstring = trimmedSentence.Substring(0, indexOfText);

            // stora små bokstäver
            string uppercaseString = trimmedSentence.ToUpper();
            string lowercaseString = trimmedSentence.ToLower();

            //struntar i språkinställningar
            string uppercaseInvariantString = trimmedSentence.ToUpperInvariant();

            // komma åt ett enskilt tecken
            char oneCharacter = trimmedSentence[0];

            for (int i = 0; i < trimmedSentence.Length; i++)
            {
                // loopa igenom en sträng, tecken för tecken. 
                char currentCharacter = trimmedSentence[i];
            }

            foreach (var currentCharacter in trimmedSentence)
            {
                // loopa igenom en sträng, tecken för tecken
                //här har man inte ett index
            }

            char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            // modifiera datat;

            trimmedSentence = new string(trimmedSentenceCharArray);

            trimmedSentence = trimmedSentence + "...";
            // samma sak som ovan
            trimmedSentence += "...";


            var numberInString = "12";
            var paddedNumberInString = numberInString.PadLeft(3, '0');

        }
    }
}
