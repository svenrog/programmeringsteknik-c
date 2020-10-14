namespace currencies
{
    class CurrencyConversion
    {
        public string Currency { get; set; }
        public int Amount { get; set; }
        public decimal ConversionRate { get; set; }
        public CurrencyConversion(string s, int i, decimal d)
        {
            Currency = s;
            Amount = i;
            ConversionRate = d;
        }
    }
}
