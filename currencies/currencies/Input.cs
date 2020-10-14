using System;
using System.Collections.Generic;
using System.Text;

namespace currencies
{
    class Input
    {
        public static bool Read()
        {
            string s = Console.ReadLine();
            if (Convert.ToChar(s) == 'y')
            {
                return true;
            }
            else if (Convert.ToChar(s) == 'n')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again. Do you want to enter a currency other than SEK? (y/n)");
                return Read();
            }

        }

        public static string ReadCurrency(List<CurrencyConversion> currencyTable)
        {
            string currencyInput = Console.ReadLine().ToUpper();
            foreach (CurrencyConversion cc in currencyTable)
            {
                if (currencyInput == cc.Currency)
                    return currencyInput;
            }
            Program.InvalidInput();
            return ReadCurrency(currencyTable);


        }
    }
}
