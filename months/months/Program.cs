using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace months
{
    enum Months { Januari, Februari, Mars, April, Maj, Juni, Juli, Augusti, September, November, December }
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program som tar en emot inmatad siffra (1-12)
            // och konverterar siffran till ett månadsnamn på svenska
            // programmet skall kasta ett fel om den inmatade siffran är något annat än 1-12.

            string userInput = Console.ReadLine();


            //while (!ValidDate(userInput, out int month)) ;

            int month = 0;

            DateTime swedishMonth;
            if (int.TryParse(userInput, out month)
            {
                if (month >= 1 && month <= 12)
                {
                    swedishMonth.Month(month);
                }
                else
                
            }


             

            
        }
        static bool ValidDate(string input, out int date)
        {
            try
            {
                date = 0;
                if (int.TryParse(input, out date))
                {
                    return true;
                }

                 if (date >= 1 && date <= 12)
                {
                    return true;
                }
                else return true;
            }
            catch (Exception ex )
            {
                date = -1;
                return false;
                throw ex;
            }


        }
    }
}
