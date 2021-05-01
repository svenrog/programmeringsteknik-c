using System;
using System.Collections.Generic;
using System.Text;

namespace currencies
{
    public class CurrencyModel
    {
        public string Date { get; set; }
        public int Section { get; set; }
        public string Currency { get; set; }
        public decimal Rate { get; set; }
    }
}
