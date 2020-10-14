
using System;
using System.Collections.Generic;

namespace currencies
{
    class TheListMaker
    {
        public static List<CurrencyConversion> Read()
        {
            string fullText = System.IO.File.ReadAllText("Resources\\Riksbanken_2020-10-13.csv");
            string[] rows = fullText.Split("\n");
            rows[0] = "";                           // Row zero is not to be used.

            List<CurrencyConversion> currencyConversionTable = new List<CurrencyConversion>();
            string[] tempContainer = new string[3];
            string[] tempContainer2 = new string[2];
            foreach (string s in rows)
            {
                if (s != null && s != "")           // Expected to discard first and last rows.
                {
                    tempContainer = s.Split(";");
                    tempContainer2 = tempContainer[1].Split(" ");
                    int amount = Convert.ToInt32(tempContainer2[0]);
                    currencyConversionTable.Add(new CurrencyConversion(tempContainer2[1], amount, Convert.ToDecimal(tempContainer[2])));
                }
            }
            return currencyConversionTable;
        }
    }
}
