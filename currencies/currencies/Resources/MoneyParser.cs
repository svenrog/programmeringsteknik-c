using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using LumenWorks.Framework.IO.Csv;
using System.IO;
using currencies.Model;
using System.Globalization;

namespace currencies.Resources
{
    class MoneyParser
    {
        //  C:\plushogskolan\programmeringsteknik-c\currencies\currencies\Resources\Riksbanken_2020-10-13.csv

        public static List<CurrencyModel> Write()
        {
            var currencies = new List<CurrencyModel>();

            using (Stream stream = File.OpenRead("Resources\\Riksbanken_2020-10-13.csv"))
            {
                const string _separator = ";";


                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        char[] delimiterChars = { ' ', ',', '.', ';', '\t' };
                        
                        string[] data = line.Split(' ', ';');

                        try
                        {
                            CurrencyModel currency = CreateCurrency(data);
                            currencies.Add(currency);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        line = reader.ReadLine();
                    }
                }

                return currencies;
            }
        }
        static CurrencyModel CreateCurrency(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (string.IsNullOrEmpty(data[i]))
                {
                    data[i] = null;
                }

            }
            var isTimeParsed = DateTime.TryParse(data[0], out var parsedTime);
            //var isMoneyParsed = decimal.TryParse(columns[2], out decimal  money);
            decimal moneyValue = decimal.Parse(data[3], CultureInfo.InvariantCulture);
            //string currencyName = columns[1].Trim();
            //currencyName.
            int amount = int.Parse(data[1]);

            return new CurrencyModel()
            {
                Time = parsedTime,
                Amount = amount,
                Name = data[2],
                Value = moneyValue,

            };
        }
    }
}
