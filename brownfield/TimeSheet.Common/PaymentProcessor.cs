using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Common.Models;

namespace TimeSheet.Common
{
    class PaymentProcessor
    {
        public static decimal CalculatePayment(PaymentModel model, int hours)
        {
            if (hours < model.HourLimit)
                throw new ArgumentException($"hours '{hours}' are less than model.HourLimit");

            return hours * model.HourlyRate;
        }
    }
}
