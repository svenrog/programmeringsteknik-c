using System;
using System.Collections.Generic;
using System.Globalization;

namespace tgif
{
    class Program
    {
        // static CultureInfo culture = new CultureInfo("sv-SE"); // For use in for example DateTime.TryParse(string, culture, DateTimeStyles.AssumeLocal, out date) 
        static void Main(string[] args)
        {
            // Skriv en applikation som läser in ett datum via användarinmatning,
            // som sedan räknar ut hur många dagar det är till nästa fredag.
            // från det inmatade datumet
            // måndag är den första dagen i veckan

            DateTime date = new DateTime();
            Console.WriteLine("Please enter a date of the format YYYY-MM-DD");
            date = Input();


            /* * * * * * * * * * * * * * * * * */
            // Metod 1; ConvertToString + switch
            string today = Convert.ToString(date.DayOfWeek);
            Console.WriteLine(today);
            switch (today)
            {
                case "Monday":
                    Console.WriteLine("Four days to go!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Three days to go!");
                    break;
                case "Wednesday":
                    Console.WriteLine("Two days to go!");
                    break;
                case "Thursday":
                    Console.WriteLine("Only one day to go!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday! (yay.)");
                    break;
                case "Saturday":
                    Console.WriteLine("Who cares about Friday, it's already the weekend! (six days to next Friday)");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday! Enjoy it while it lasts! Five days to next Friday.");
                    break;
            }



            /* * * * * * * * * * */
            // Metod 2, Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Monday", 4);
            dictionary.Add("Tuesday", 3);
            dictionary.Add("Wednesday", 2);
            dictionary.Add("Thursday", 1);
            dictionary.Add("Friday", 0);
            dictionary.Add("Saturday", 6);
            dictionary.Add("Sunday", 5);

            Console.WriteLine($"There are {dictionary[today]} days to go to Friday.");



            /* * * * * * * * * * * * * * * */
            // Metod 3, integer calculations
            int dayNumber = (int)date.DayOfWeek;
            int daysToFriday = (int)DayOfWeek.Friday - dayNumber;
            if (daysToFriday < 0)
            {
                Console.WriteLine("Enjoy the weekend!");
            }
            else if (daysToFriday == 0)
            {
                Console.WriteLine("It's Friday! Enjoy the weekend!");
            }
            else
            {
                Console.WriteLine($"There are {daysToFriday} days until Friday.");
            }

        }

        private static DateTime Input()
        {
            DateTime input = new DateTime();

            try
            {
                input = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again, remember the format is YYYY-MM-DD");
                input = Input();
            }

            return input;
        }
    }
}
