using currencies.Models;
using currencies.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace currencies
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Skriv ett program som läser in en fil med växlingskurser och
            // sedan konverterar en inmatad valuta till svenska kronor.

            // Exempelvis: 100 USD, eller 50 GBP
            
            // Exempelvis ut: 900 SEK

            // 2. Skapa sedan ett uppslagsverk med valutanamn och skriv ut namnen på valutorna konverteringen sker emellan.
            // (Valutor lagras på RegionInfo, en egenskap på CultureInfo)
            
            // Alla CultureInfo-objekt kan hämtas via CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            
            // 3. Lägg till ett ytterligare val för valuta att konvertera till (förutom SEK). 

            // Exempelvis: 100 USD -> GBP eller AUD

            string targetCurrency = "SEK";
            string targetPath = "Resources\\Riksbanken_2020-10-13.csv";
            MoneyConverter moneyConverter = new MoneyConverter(targetPath, targetCurrency);

            Console.WriteLine("Skriv in önskad växlings-valuta och mängd (t.ex. 100 USD)");
            string input = Console.ReadLine();

            Console.WriteLine("Skriv vilken valuta du vill växla till (t.ex. GBP)");
            string currencyInput = Console.ReadLine();

            Money enteredMoney = MoneyParser.Parse(input);
            Money convertedMoney = moneyConverter.ConvertToTargetCurrency(enteredMoney);

            if (currencyInput != targetCurrency)
            {
                convertedMoney = moneyConverter.ConvertFromTargetCurrency(convertedMoney.Amount, currencyInput);
            }

            Console.WriteLine($"Dina {enteredMoney} ({GetCurrencyName(enteredMoney)}) blir {convertedMoney} ({GetCurrencyName(convertedMoney)})");
        }

        public static string GetCurrencyName(Money money)
        {
            return CurrencyLookup.GetCurrencyName(money.Currency);
        }
    }
}
