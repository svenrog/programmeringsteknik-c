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
            // från det inmatade datumet
            // måndag är den första dagen i veckan



            DateTime date;

            while (!GetDateFromUser(out date)) ;
 
            DayOfWeek givenDay = date.DayOfWeek;
            DayOfWeek friday = DayOfWeek.Friday;

            int diffrence = friday - givenDay;

            if (diffrence < 0)
            {
                diffrence += 7;
            }


            Console.WriteLine($"There are {diffrence} days until next friday!");

            


        }
        static bool GetDateFromUser(out DateTime date)
        {
            Console.WriteLine("Enter a date: ");
            string input = Console.ReadLine();

            CultureInfo culture = new CultureInfo("sv-SE");

            return DateTime.TryParse(input, culture, DateTimeStyles.AssumeLocal, out date);
        }
    }
}
