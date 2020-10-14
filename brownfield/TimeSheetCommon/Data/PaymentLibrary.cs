using System.Collections.Generic;
using TimeSheetCommon.Models;

namespace TimeSheetCommon.Data
{
    class PaymentLibrary
    {
        public static List<PaymentModel> GetPayment()
        {
            return new List<PaymentModel>
            {
                new PaymentModel { Label = "overtime", HourLimit = 40, HourlyRate = 75 },
                new PaymentModel { Label = "time", HourLimit = 0, HourlyRate = 50 }
            };
        }
    }
}
