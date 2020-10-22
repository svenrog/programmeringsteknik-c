using System;

namespace currencies.Models
{
    public struct Money
    {
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency.ToUpper();
        }

        public decimal Amount { get; }
        public string Currency { get; }

        public override string ToString()
        {
            return $"{Math.Round(Amount, 2)} {Currency}";
        }
    }
}
