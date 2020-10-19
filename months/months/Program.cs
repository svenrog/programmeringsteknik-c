using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;

namespace months
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program som tar en emot inmatad siffra (1-12)
            // och konverterar siffran till ett månadsnamn på svenska
            // programmet skall kasta ett fel om den inmatade siffran är något annat än 1-12.

            Console.Write("Enter a number (1-12): ");
            string input = Console.ReadLine();
            int monthNumber = int.Parse(input);

            if (monthNumber < 1 || monthNumber > 12)
                throw new ArgumentOutOfRangeException(nameof(input), "value must be, or be between 1 and 12");

            CultureInfo culture = SettingsFactory.GetCulture();
            DateTimeFormatInfo dateFormat = culture.DateTimeFormat;
            TextInfo textFormat = culture.TextInfo;

            string monthName = dateFormat.GetMonthName(monthNumber);
            string monthNameFormatted = textFormat.ToTitleCase(monthName);

            Console.WriteLine(monthNameFormatted);
        }
    }
}
