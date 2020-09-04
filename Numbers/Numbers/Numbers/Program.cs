using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            Console.WriteLine("skriv ett antal nummmer separerade med semicol!");
            var userInput = Console.ReadLine();
            string[] userInputArray = userInput.Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<double> numberList = new List<double>();

            foreach(string stringNumber in userInputArray)
                if (Double.TryParse(stringNumber, out double doubleNumber)) numberList.Add(doubleNumber);

            if (numberList.Count > 0)
            {
                double numberMaxValue = numberList.Max();
                double numberMinValue = numberList.Min();
                double sumValues = 0;
                foreach (double value in numberList)
                    sumValues += value;
                double numberMedianValue = sumValues / numberList.Count;

                Console.WriteLine($"Lägsta värdet: {numberMinValue}");
                Console.WriteLine($"Högsta värdet: {numberMaxValue}");
                Console.WriteLine($"Medelvärdet: {numberMedianValue}");
            }
            else Console.WriteLine("inga av värden är nummer");
        }
    }
}