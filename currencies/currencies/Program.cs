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
            List<CurrencyConversion> currencyConversionTable = TheListMaker.Read();
            Console.WriteLine("Please input a currency and amount in the same form as 'CAD 123'.");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(" ");


            if (splitInput.Length != 2)                 // Kollar att det blir rätt antal efter split
                InvalidInput();

            else if (splitInput[0].Length != 3)         // Kollar att det är tre tecken långt och därmed passar formatet. Mer ordentlig check skulle kräva en foreach loop.
                InvalidInput();

            else
            {
                Console.WriteLine("Would you like to convert to some other currency than SEK? (y/n)");
                bool yes = Input.Read();

                if (yes)                                // Branch för annan valuta än SEK
                {
                    Console.WriteLine("Please select a currency from the following list: ");

                    foreach (CurrencyConversion cc in currencyConversionTable)              // Skriver ut lista av korrekta inputs
                    {
                        Console.WriteLine(cc.Currency);
                    }

                    string currencyInput = Input.ReadCurrency(currencyConversionTable);     // Läser in korrekt input. Metoden körs i loop tills den får rätt input
                    Console.Clear();

                    try                                 // Om det blivit fel i något input kommer det bli ett fel nånstans i denna kod, och catch skickar då ut ett felmeddelande
                    {                                   // Programmet avslutas i så fall.
                        int inputAmount = Convert.ToInt32(splitInput[1]);
                        decimal conversionRateToSEK = 1;
                        decimal conversionRateFromSEK = 1;
                        int currencyModifierAmountTo = 1;
                        int currencyModifierAmountFrom = 1;                                 // Värden sätts till ett för att undvika "divide by zero" ifall foreach misslyckas.

                        foreach (CurrencyConversion cc in currencyConversionTable)          // Kan alltid sättas till noll för att få exceptions när något går fel.
                        {
                            if (cc.Currency == currencyInput)                               // Hämtar ut värden som behövs för att köra från input valutan till SEK
                            {
                                conversionRateFromSEK = cc.ConversionRate;
                                currencyModifierAmountFrom = cc.Amount;
                            }
                            if (cc.Currency == splitInput[0])                               // Hämtar ut värden som behövs för att köra från SEK till valda valutan
                            {
                                conversionRateToSEK = cc.ConversionRate;
                                currencyModifierAmountTo = cc.Amount;
                            }
                        }

                        decimal modifiedConversionRate = (conversionRateToSEK / currencyModifierAmountTo) / (conversionRateFromSEK / currencyModifierAmountFrom);
                        // Skapar ett kombinerat värde som kan sättas direkt på input mängden för att modifiera till valda valutan.

                        Console.WriteLine($"Your input in {currencyInput} is: {inputAmount * modifiedConversionRate}.");

                    }

                    catch
                    {
                        InvalidInput();
                    }

                }
                else                                    // Branch för SEK
                {
                    try
                    {
                        int inputAmount = Convert.ToInt32(splitInput[1]);
                        foreach (CurrencyConversion cc in currencyConversionTable)          // Går igenom varje valutatyp           
                        {
                            if (cc.Currency == splitInput[0])                               // Testar efter den valda valutan
                            {
                                Console.WriteLine($"Your input in SEK is: {inputAmount * cc.ConversionRate / cc.Amount}.");
                            }
                        }
                    }
                    catch                                                                   // Träffas ifall input är felaktig någonstans.
                    {
                        InvalidInput();
                    }
                }
            }
        }

        public static void InvalidInput()
        {
            Console.WriteLine("Invalid input");
        }
    }
}
