using Microsoft.VisualBasic;
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
            // Från det inmatade värdet. Day of time US. är Söndag

            //DateTime userInput = new DateTime();
            ////DateTime nextFriday = DateTime.Parse("1/12/2002");
            //CultureInfo culturalInfo = CultureInfo.InvariantCulture;

            //Console.WriteLine("Mata in ett datum. yyyy/mm/dd");
            //userInput = Convert.ToDateTime(Console.ReadLine());

            //DateTime nextFriday = DateTime.ParseExact("10/16/2020", "MM/dd/yyyy", culturalInfo);

            //int daysBetween = (nextFriday.Date - userInput.Date).Days;

            //Console.WriteLine($"Antal dagar mellan inmatade datum till nästa fredag är: {daysBetween}");


            DateTime date;
            //DateTime nextFriday = DateTime.Parse("2020/10/16");

            while (!GetDateFromUser(out date));

                DayOfWeek givenDay = date.DayOfWeek;
                DayOfWeek friday = DayOfWeek.Friday;

                int daysBetween = friday - givenDay;

                if (daysBetween < 0)
                    daysBetween += 7;

                Console.WriteLine($"There are {daysBetween} days until next friday.");


            //{
            //    int daysBetween = (nextFriday.Date - date.Date).Days;

            //    Console.WriteLine($"Antal dagar mellan inmatade datum till nästa fredag är: {daysBetween}");
            //}
            Console.ReadLine();
        }
        static bool GetDateFromUser(out DateTime date) // Do this!
        {
            Console.WriteLine("Enter a date: ");
            string input = Console.ReadLine();
            
            CultureInfo culture = new CultureInfo("sv-SE");


            return DateTime.TryParse(input, culture, DateTimeStyles.AssumeLocal, out date);
        }
    }
}
