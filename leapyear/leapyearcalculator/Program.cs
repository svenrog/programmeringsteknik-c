using Microsoft.VisualBasic;
using System;
using System.Runtime.ExceptionServices;

namespace leapyearcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Räkna ut hur många skottår som passerat mellan två inmatade värden.
            //int firstYear, secondYear;

            //int leapYearCounter = 0;
            //Console.WriteLine("Första året");
            //firstYear = int.Parse(Console.ReadLine());
            //Console.WriteLine("Andra året");
            //secondYear = int.Parse(Console.ReadLine());

            //if (firstYear >= 0 && secondYear >= 0)
            //    if (firstYear > secondYear)
            //    {
            //        var year = firstYear;
            //        firstYear = secondYear;
            //        secondYear = year;

            //    }

            //for (int i = firstYear; i < secondYear; i++)
            //{
            //    bool IsLeapYear = DateTime.IsLeapYear(i);
            //    if (IsLeapYear)
            //        ++leapYearCounter;

            //}
            //Console.WriteLine($"Antal skottår som passerat: {leapYearCounter}");
            //Console.ReadKey();

            int firstYear = int.Parse(args[0]);
            int secondYear = int.Parse(args[1]);

            int maxYear = Math.Max(firstYear, secondYear);
            int minYear = Math.Min(firstYear, secondYear);

            int leapYearCount = 0;

            for (int year = minYear; year <= maxYear; year++)
            {
                bool IsLeapYear = DateTime.IsLeapYear(year);
                
                if (IsLeapYear)
                    leapYearCount++;
                
            }
            Console.WriteLine($"Encountered {leapYearCount} from {minYear} - {maxYear}");
            Console.ReadKey();

            // DateTime.IsLeapYear(year) är en metod man kan använda.
        }
    }
}
