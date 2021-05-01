using System;

namespace leapyearcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Räkna ut hur många skottår som passerat mellan två inmatade värden.

            // DateTime.IsLeapYear(year) är en metod man kan använda.
            int firstYear = int.Parse(args[0]);
            int secondYear = int.Parse(args[1]);

            int maxYear = Math.Max(firstYear, secondYear);
            int minYear = Math.Min(firstYear, secondYear);

            Calculations leapYears = new Calculations();

            int totalLeapYears = leapYears.CalcLeap(minYear, maxYear);
            Console.WriteLine($"Total amount of leap years: {totalLeapYears} found between {firstYear} and {secondYear}");
        }
    }
}
