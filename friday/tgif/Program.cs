using System;
using System.Globalization;

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
            // som sedan räknar ut hur många dagar det är till nästa fredag.

            DateTime date;
            while (!GetDateFromUser(out date));


            DayOfWeek givenDay = date.DayOfWeek;
            DayOfWeek thisFriday = DayOfWeek.Friday;
            int difference = thisFriday - givenDay;

            if (difference < 0)
                difference += 7;

            Console.WriteLine($"Dagen är en {givenDay}. Det betyder att det är {difference} dagar kvar tills nästa fredag.");
            Console.ReadKey();
        }

        static bool GetDateFromUser(out DateTime date)
        {
            Console.WriteLine("Ange ett datum (YYYY-MM-DD):");
            string input = Console.ReadLine();

            CultureInfo culture = new CultureInfo("sv-SE");

            return DateTime.TryParse(input, culture, DateTimeStyles.AssumeLocal, out date);
        }
    }
}
