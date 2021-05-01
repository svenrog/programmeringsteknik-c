using System;
using System.Globalization;

namespace months
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program som tar en emot inmatad siffra (1-12)
            // och konverterar siffran till ett månadsnamn på svenska
            // programmet skall kasta ett fel om den inmatade siffran är något annat än 1-12.

            //int result = 0;
            //while (result < 1)                
            //    while (!int.TryParse(Console.ReadLine(), out result));



            Console.Write("Enter a number (1-12):");
            string input = Console.ReadLine();
            int monthNumber = int.Parse(input);

            CultureInfo culture = SettingsFactory.GetCulture();
            DateTimeFormatInfo dateFormat = culture.DateTimeFormat;
            TextInfo textFormat = culture.TextInfo;

            if ( monthNumber < 1 ||  monthNumber > 12)
            {
                throw new Exception("Number is out of range");
            }
            string monthName = dateFormat.GetMonthName(monthNumber);
            string monthNameFormat = textFormat.ToTitleCase(monthName);


        }
    }
}
