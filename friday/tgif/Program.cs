using System;
using System.Globalization;

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en applikation som läser in ett datum via användarinmatning,
            //som sedan räknar ut hur många dagar det är till nästa fredag.
            CultureInfo culture = new CultureInfo("sv-SE");
           Console.WriteLine("Skriv år: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv månad: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv dag: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime datum = new DateTime(year, month, day);
            Console.WriteLine($"Det är {datum.DayOfWeek}");
            int daysUntilFriday = 0;
            for (int i = 0; i < 7; i++)
            {
                DateTime compareDate = datum.AddDays(i);
                //string whatDay = Convert.ToString(compareDate.DayOfWeek);
                if (compareDate.DayOfWeek == DayOfWeek.Friday)
                {
                    daysUntilFriday = i;
                }
            }
            Console.WriteLine($"{daysUntilFriday} dagar tills det är fredag!");
        }
    }
}
