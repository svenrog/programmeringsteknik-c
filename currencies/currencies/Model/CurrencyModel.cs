using System;
using System.Collections.Generic;
using System.Text;

namespace currencies.Model
{
    public class CurrencyModel
    {
        public DateTime Time { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
