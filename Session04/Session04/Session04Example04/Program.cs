using System;

namespace Session04Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = " ";

            //kontrollera om strängen har ett värde
            bool inputIsNull = inputData == null;
            bool inputIsEmpty = inputData == string.Empty; //går även att göra inputData == "";

            //snabbmetoder för att kontrollera innehållet i en sträng
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            //ytterligare kontroller om strängen innehåller vettig data
            bool inputIsNullOrWhitespae = string.IsNullOrWhiteSpace(inputData);

            string sentence = "    This is a sentence of text, it contains many words.     ";

            // Trimma bort mellanslag och andra whitespace-tecken från början och slutet
            string trimmedSentence = sentence.Trim();
            string endTrimmedSentence = sentence.TrimEnd();
        }
    }
}
