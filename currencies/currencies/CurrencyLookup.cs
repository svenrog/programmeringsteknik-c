using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace currencies
{
    static class CurrencyLookup
    {
        private static IDictionary<string, string> _currencies;
        static CurrencyLookup()
        {
            _currencies = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            GenerateCurrencyList();
        }
        public static string GetCurrencyName(string currencyCode)
        {
            return _currencies[currencyCode];
        }
        private static void GenerateCurrencyList()
        {
            var cultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var cultureInfo in cultureInfos)
            {
                if (cultureInfo.IsNeutralCulture)
                    continue;

                RegionInfo region = new RegionInfo(cultureInfo.LCID);

                if (_currencies.ContainsKey(region.ISOCurrencySymbol))
                    continue;

                _currencies.Add(region.ISOCurrencySymbol, region.CurrencyEnglishName);

            }
        }
    }
}
