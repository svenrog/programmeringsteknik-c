using System.Collections.Generic;
using System.IO;

namespace currencies
{
    public class LoadCurrencyData
    {
        const string path = @"C:\plushogskolan\programmeringsteknik-c\currencies\currencies\Resources\\Riksbanken_2020-10-13.csv";

        public static List<CurrencyModel> GetData()
        {
            List<CurrencyModel> currency = new List<CurrencyModel>();
            using (Stream stream = File.OpenRead(path))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] values = line.Split(';');
                        var temp = values[3].Replace('.', ',');

                        CurrencyModel model = new CurrencyModel
                        {
                            Date = values[0],
                            Section = int.Parse(values[1]),
                            Currency = values[2],
                            Rate = decimal.Parse(temp)
                        };
                        currency.Add(model);
                    }
                }
            }
            return currency;
        }
    }
}
