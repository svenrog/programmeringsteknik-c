using System;

namespace NullbaraVärdetyper
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            char?[] nullableCharArray = new char?[] { 'a', null, 'b' };
            //? krävs för att lägga till konceptet då det är en värdetyp

            //nullableInteger.HasValue;
            //nullableInteger.Value;

            for (var i = 0; i < nullableCharArray.Length; i++)
            {
                char? currentChar = nullableCharArray[i];

                //för att kontrollera om värdet är null kan man 
                if (currentChar.HasValue == false) continue;
                //eller
                if (currentChar == null) continue;

                //för att komma åt ett värde kan man 
                char currentCharValue = currentChar.Value;
                //eller
                currentCharValue = (char)currentChar; //värdekonvertering

            }

            string defaultString = null;

            // Olika typer av konstanter
           int minValue = int.MinValue;
           int maxValue = int.MaxValue;
           double nanValue = double.NaN;
           double infinityValue = double.PositiveInfinity;
        }
    }
}
