using currencies.Models;
using currencies.Services;
using System;

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

            string targetCurrency = "SEK";
            string targetPath = "Resources\\Riksbanken_2020-10-13.cs";
            MoneyConverter moneyConverter = new MoneyConverter(targetPath, targetCurrency);

            Console.WriteLine("Skriv in önskad växlings-valuta och mängd (tex. 100 USD)");
            string input = Console.ReadLine();

            Console.WriteLine("Skriv vilken valuta du vill växla till (tex. GBP)");
            string currencyInput = Console.ReadLine();

            Money enteredMoney = MoneyParser.Parse(input);
            Money convertedMoney = moneyConverter.ConvertToTargetCurrency(enteredMoney);

            if (currencyInput != targetCurrency)
            {
                convertedMoney = moneyConverter.ConvertFromTargetCurrency(convertedMoney.Amount, currencyInput);
            }

            Console.WriteLine($"Dina {enteredMoney} ({GetCurrencyName(enteredMoney)})blir {convertedMoney}.");

        }

        public static string GetCurrencyName(Money money)
        {
            return CurrencyLookup.GetCurrencyName(money.Currency);
        }
    }
}
