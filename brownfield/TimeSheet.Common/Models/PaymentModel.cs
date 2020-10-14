using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Common.Models
{
    public class PaymentModel
    {
        public int HourLimit { get; set; }
        public string Label { get; set; } = "time";
        public decimal HourlyRate { get; set; }
    }
}
