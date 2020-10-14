using System;
using System.Globalization;

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
            DateTime userDate;

            while (!GetDateFromUser(out userDate)) ;

            DayOfWeek friday = DayOfWeek.Friday;
            Console.WriteLine(friday);

            userDate.AddDays(7);
            
            int difference = friday - userDate.DayOfWeek;
  
            Console.WriteLine($"Det är såhär många dagar kvar: {difference}");     
            Console.ReadKey();
            // som sedan räknar ut hur många dagar det är till nästa fredag.
        }

        static bool GetDateFromUser(out DateTime date)
        {
            Console.WriteLine("Skriv in datum");
            string input = Console.ReadLine();

            CultureInfo culture = new CultureInfo("sv-SE");
            return DateTime.TryParse(input, culture, DateTimeStyles.AssumeLocal, out date); //CultureInfo.InvariantCulture

        }
    }
}
