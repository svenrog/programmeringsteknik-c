using System;
using System.Diagnostics;
using System.Threading;

namespace TimeAndDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vad klockan är
            DateTime currentDateTime = DateTime.Now;
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow;

            //Kontrollerar skottår
            DateTime.IsLeapYear(currentDateTime.Date.Year);

            //Maximala och minimala tiden
            DateTime minValue = DateTime.MinValue;
            DateTime maxValue = DateTime.MaxValue;

            //Hämta ut ett datum från en sträng
            var parsedDate = DateTime.Parse("2020-01-01");
            //DateTime failedParseDate = DateTime.Parse("asdf");

            //out-parameter sätter alltid värdet, parsedDate är ändrat
            //DateTime.TryParse fungerar på samma sätt som int.TryParse...
            bool dateWasParsed = DateTime.TryParse("asdf", out parsedDate);

            // Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            // baseras på ticks
            // currentTime.Ticks;
            
            //Hur många Ticks som går på en sekund
            //TimeSpan.TicksPerSecond;

            TimeSpan createdTimeSpan = new TimeSpan(1,2,3);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Pausa programmet manuellt
            Thread.Sleep(1000);

            timer.Stop();

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1).AddSeconds(-1);

            TimeSpan resultOfTwoTimes = today - yesterday;

            //Formattera, skriva ut tid
            Console.WriteLine(resultOfTwoTimes);

            //Formattera datum
            Console.WriteLine($"{ currentDateTime:yyyy-MM-dd}");
            Console.WriteLine(currentDateTime);

        }
    }
}
