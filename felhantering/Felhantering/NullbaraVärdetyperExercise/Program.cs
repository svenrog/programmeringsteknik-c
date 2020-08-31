using System;

namespace NullbaraVärdetyperExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null; //? behövs för att det är en värdetyp
            double? nullableDouble = null;
            char?[] nullableCharArray = new char?[] { 'a', null, 'b' };

            //nullableInteger.HasValue;
            //nullableInteger.Value;

            for(var i = 0; i < nullableCharArray.Length; i++)
            {
                char? currentChar = nullableCharArray[i];
                //för att kontrollera om värdet är null kan man
                if (currentChar.HasValue == false) continue;
                //eller
                if (currentChar == null) continue;

                //för att komma åt ett värde kan man
                char currentCharValue = currentChar.Value;
                //eller
                currentCharValue = (char)currentChar;

                
            }
            string defaultString = null;

            //Olika typer av konstanter
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            double minValue = double.MaxValue;
            double minValue = double.MinValue;
            double nanValue = double.NaN;
            double infinityValue = double.PositiveInfinity; 



        }
    }
}
