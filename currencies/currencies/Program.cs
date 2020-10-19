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

            // 2. Skapa sedan ett uppslagsverk med valutanamn och skriv ut namnen på valutorna konverteringen sker emellan.
            // (Valutor lagras på RegionInfo, en egenskap på CultureInfo) 

            // 3. Lägg till ett ytterligare val för valuta att konvertera till (förutom SEK)

            var currencies = GetCurrencies();

            Console.Write("How much money do you have? ");
            decimal inputMoneyAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What currency is it?");
            foreach (var currencie in currencies)
            {
                Console.Write($"{currencie.Key}, ");
            }
            Console.Write("\n");
            string inputFromCurrency = Console.ReadLine();

            Console.Write("Do you want know how much is that in SEK? [yes/no] ");
            string userAnswer = Console.ReadLine();
            decimal outputMoneyAmount = Math.Round(inputMoneyAmount * currencies[inputFromCurrency], 2);

            if (userAnswer.ToLower() == "yes")
                Console.WriteLine(
                    $"{inputMoneyAmount} " +
                    $"{inputFromCurrency} " +
                    $"{CurrencyLookup.GetCurrencyName(inputFromCurrency)} is " +
                    $"{outputMoneyAmount} SEK");

            Console.Write("Do you want know how much is that in an other currency? [yes/no] ");
            userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == "yes")
            {
                Console.Write("What currency? ");
                string inputToCurrency = Console.ReadLine();
                decimal otherCurrensyOutputMoney = Math.Round(outputMoneyAmount / currencies[inputToCurrency], 2);
                Console.Write(
                    $"{inputMoneyAmount} " +
                    $"{inputFromCurrency} " +
                    $"{CurrencyLookup.GetCurrencyName(inputFromCurrency)} is " +
                    $"{otherCurrensyOutputMoney} " +
                    $"{inputToCurrency} " +
                    $"{CurrencyLookup.GetCurrencyName(inputToCurrency)}");
            }
        }

        public static Dictionary<string, decimal> GetCurrencies()
        {
            Dictionary<string, decimal> currencies = new Dictionary<string, decimal>();
            using (Stream stream = File.Open(".\\Resources\\Riksbanken_2020-10-13.csv", FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                reader.ReadLine();
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] columns = line.Split(';');

                    currencies.Add(
                        columns[1].Split(' ')[1],
                        Convert.ToDecimal(columns[2].Replace('.', ',')) / Convert.ToDecimal(columns[1].Split(' ')[0]));

                    line = reader.ReadLine();
                }
            }
            return currencies;
        }
    }
}
