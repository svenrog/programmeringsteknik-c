using System;
using System.Collections.Generic;

namespace currencies
{
    public class CurrencyConverter
    {
        public decimal GetNewCurrency(string inputFrom, string inputTo, decimal amount, List<CurrencyModel> currency)
        {
            decimal result = 0;
            decimal fromCurrency = 0;
            decimal toCurrency = 0;
            foreach (var el in currency)
            {
                if (el.Currency.Contains(inputFrom))
                {
                    fromCurrency = el.Rate;
                }
            }
            foreach(var item in currency)
            {
                if (item.Currency.Contains(inputTo))
                {
                    toCurrency = item.Rate;
                }
            }
            
            //From targetCurrency division
            //To   targetCurrency multi

            //foreach(var section in currency)
            //{
            //    if (section.Currency.Contains(inputTo))
            //    {
            //        if (section.Section == 100)
            //        {
            //            result = amount * (fromCurrency / toCurrency);
            //        }
            //        else if (section.Section == 1)
            //        {
            //            result = amount * (toCurrency / fromCurrency);
            //        }                 
            //    }                
            //}           
            return Math.Round(result,2);
        }
    }
}
