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

            // Exempelvis: 100 USD, eller 50 GBP

            // Exempelvis: 900 SEK

            // 2. Skapa sedan ett uppslagsverk med valutanamn och skriv ut namnen på valutorna konverteringen sker emellan.
            // (Valutor lagras på RegionInfo, en egenskap på CultureInfo) 

            // 3. Lägg till ett ytterligare val för valuta att konvertera till (förutom SEK).

            // Exempelvis: 100 USD -> GBP eller AUD
            
            List<CurrencyModel> currency = LoadCurrencyData.GetData();

            foreach (var el in currency)
            {
                Console.WriteLine(el.Currency + " " + el.Rate);
            }

            string inputFrom = "NOK";
            string inputTo = "USD";
            decimal amountInput = 500;

            //Console.WriteLine("Please write your current currency: ");
            //inputFrom = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Write the amount you want to exchange: ");
            //amountInput = decimal.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Finally write the currency you want to exchange to: ");
            //inputTo = Console.ReadLine();

            var convertedUserInput = new CurrencyConverter().GetNewCurrency(inputFrom,inputTo,amountInput,currency);

            
            Console.WriteLine($"You will get {convertedUserInput} {inputTo} after exchange");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
