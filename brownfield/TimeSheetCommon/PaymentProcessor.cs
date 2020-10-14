using System;
using TimeSheetCommon.Models;

namespace TimeSheetCommon
{
    public class PaymentProcessor
    {
        public static decimal CalculatePayment(PaymentModel model, int hours)
        {
            if (hours < model.HourLimit)
                throw new ArgumentException($"Hours {hours} are less than {model.HourLimit}");

            return hours * model.HourlyRate;
        }
    }
}
