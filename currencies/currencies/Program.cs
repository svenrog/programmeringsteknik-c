using currencies.Model;
using currencies.Resources;
using System;
using System.Collections.Generic;

namespace currencies
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Skriv ett program som läser in en fil med växlingskurser och
            // sedan konverterar en inmatad valuta till svenska kronor.

            // 2. Skapa sedan ett uppslagsverk med valutanamn och skriv ut namnen på valutorna konverteringen sker emellan.
            // (Valutor lagras på RegionInfo, en egenskap på CultureInfo) 

            // 3. Lägg till ett ytterligare val för valuta att konvertera till (förutom SEK).  


            // 1

           
            Console.WriteLine("Mata in en valuta att växla till svenska kronor");
            string input = Console.ReadLine().ToUpper();

            Console.WriteLine(input);

            var currencies = new List<CurrencyModel>();
            currencies = MoneyParser.Write();

            currencies.RemoveAt(0);

            foreach (var foreignValue in currencies)
            {

                if (input.Equals(foreignValue.Name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Valutan {foreignValue.Name} i förhållande till {foreignValue.Amount}  svenska kronor är {foreignValue.Value}");
                }
            }

            //}
            //else throw new ArgumentException("Invalid currency code");

            foreach (var currency in currencies)
            {
                Console.WriteLine("Date: " + currency.Time);
                Console.WriteLine("Name: " + currency.Name);
                Console.WriteLine("Value: " + currency.Value);
                Console.WriteLine();
            }

            Console.ReadKey();
            //var currencies = new Dictionary<string, decimal>() { }
        }
    }
}
