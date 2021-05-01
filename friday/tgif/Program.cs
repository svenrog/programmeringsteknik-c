using System;
using System.Collections.Generic;
using System.Globalization;

namespace tgif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
            // som sedan räknar ut hur många dagar det är till nästa fredag.
            //från det inmatade värdet.
            //måndag är den första dagen i veckan.

            //string today = DateTime.UtcNow.DayOfWeek.ToString().ToLower();
            //Dictionary<string, int> calc = new Dictionary<string, int>();
            //calc.Add("monday", 1);
            //calc.Add("tuesday", 2);
            //calc.Add("wednesday", 3);
            //calc.Add("thursday", 4);
            //calc.Add("friday", 5);
            //calc.Add("saturday", 6);
            //calc.Add("sunday", 7);
            //int days;

            //while (true)
            //{
            //    Console.WriteLine("Write a weekday or exit to quit: ...");
            //    string input = Console.ReadLine().ToLower();

            //    switch(input)
            //    {
            //        case "monday":  Console.WriteLine(days = Calc(calc, input));
            //            break;
            //        case "tuesday": Console.WriteLine(days = Calc(calc, input));
            //            break;
            //        case "wednesday": Console.WriteLine(days = Calc(calc, input));
            //            break;
            //        case "thursday": Console.WriteLine(days = Calc(calc, input));
            //            break;
            //        case "friday":  Console.WriteLine(days = Calc(calc, input));
            //            break;
            //        case "saturday":    Console.WriteLine(days = 6);                      
            //            break;
            //        case "sunday":   Console.WriteLine(days = 5);
            //            break;
            //        case "exit":    Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Please write a day correctly typed");
            //            break;
            //    }                
            //}

            //int Calc (Dictionary<string,int> calc, string input)
            //{
            //    int days = calc["friday"] - calc[input];
            //return days;
            //}
            // Feltolkad specifikation, vi börjar om nedan.

            DateTime date;
            while(!GetDateFromUser(out date))
            {
                DayOfWeek givenDay = date.DayOfWeek;
                DayOfWeek friday = DayOfWeek.Friday;

                int difference = friday - givenDay;

                if (difference < 0)
                    difference += 7;
                Console.WriteLine($"There are {difference} days until next friday");
                Console.ReadKey();
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
}
