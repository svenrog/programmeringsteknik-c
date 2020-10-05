using System;

namespace leapyearcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Räkna ut hur många skottår som passerat mellan två inmatade värden.

            // DateTime.IsLeapYear(year) är en metod man kan använda.
            Calculations LeapYears = new Calculations();

            int totalLeapYears = LeapYears.CalcLeap(1992, 2020);
            Console.WriteLine(totalLeapYears);
        }
    }
}
