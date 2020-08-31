using System;
using System.Diagnostics;
using System.Threading;

namespace TimeDateExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // vad klockan är

            DateTime currentDateTime = DateTime.Now;
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow; // datorer pratar med datorer, man måste justera till sin egen tid

            // kontrollerar skottår
            DateTime.IsLeapYear(currentDateTime.Year);


            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;

            // Hämta ut ett datum från en sträng
            var parsedDate = DateTime.Parse("2020-01-01");
            // fel datuminmatning
            DateTime failedParseDate = DateTime.Parse("adsf");

            // oute-parameter sätter alltid värdet, paresDate är ändrat
            //DateTime.TryParse fungerar på samma sätt som int.TryParse...
            bool dateWasParsed = DateTime.TryParse("adsf", out parsedDate);

            //Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            // baseras på ticks
            // currentTime.Ticks;

            // hur många ticks som går på en sekund
            // TimeSpan.TicksPerSecond:

            TimeSpan createdTimeSpan = new TimeSpan(1, 2, 3);

            // mäta tid tex från att ett program startas till att det avslutas
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // pausa programmet manuellt
            Thread.Sleep(1000);

            timer.Stop();

            // om mäta hur snabbt en kod körs
            // timer.ElapsedTicks 

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1)
                                               .AddSeconds(-1); // radbryt för att göra tydligare (; avslutar)

            TimeSpan resultOfTwoTimes = today - yesterday;

            TimeSpan negativeResultOfTwoTimes = yesterday - today;

            //Formattera datum
            Console.WriteLine($"{currentTime:yyyy-MM-dd}");


        }
    }
}
