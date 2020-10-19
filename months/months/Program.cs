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
            while (true) 
            {
                Console.WriteLine("Skriv siffra 1-12");
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                if (monthNumber > 0 && monthNumber < 13)
                {
                    var month = new DateTime(2020, monthNumber, 1);
                    Console.WriteLine(month.ToString("MMMM", CultureInfo.CreateSpecificCulture("lv-LV")));
                    Console.WriteLine(month.ToString("MMMM", CultureInfo.CreateSpecificCulture("sv-SE")));

                    Console.WriteLine(month.ToString("MMMM", CultureInfo.CreateSpecificCulture("tr-TR")));
                }
                else
                    //throw new ArgumentException("fel siffra (1-12");
                    Console.WriteLine("Fel siffra.\n");

            }
            
            
        }
    }
}
