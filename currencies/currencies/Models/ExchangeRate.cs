using System;
using System.Collections.Generic;
using System.Text;

namespace currencies.Models
{
    public class ExchangeRate
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public decimal ConversionRate { get; set; }
    }
}
