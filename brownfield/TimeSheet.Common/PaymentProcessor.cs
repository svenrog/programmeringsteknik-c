using System;
using TimeSheet.Common.Models;

namespace TimeSheet.Common
{
    public class PaymentProcessor
    {
        public static decimal CalculatePayment(PaymentModel model,int hours)
        {
            if (hours < model.HourLimit)
                throw new ArgumentException($"'{hours}' are less than model.hourLimit '{model.HourLimit}'");

            return hours * model.HourlyRate;
        }
    }
}
