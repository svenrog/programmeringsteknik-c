using currencies.Models;
using System;
using System.Globalization;

namespace currencies.Services
{
    public static class MoneyParser
    {
        public static Money Parse(string input)
        {
            string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (data.Length < 2)
                throw new ArgumentOutOfRangeException($"Missing data for money conversion from '{input}'");

            decimal amount = ParseAmount(data[0]);

            return new Money(amount, data[1]);

        }

        public static decimal ParseAmount(string input)
        {
            return decimal.Parse(input, CultureInfo.InvariantCulture);
        }
    }
}
