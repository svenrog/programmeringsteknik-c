using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Common.Models;

namespace TimeSheet.Common.Data
{
    public class PaymentLibrary
    {
        public static List<PaymentModel> GetPayments()
        {
            return new List<PaymentModel>
            {
                new PaymentModel { Label = "overtime", HourLimit = 40, HourlyRate = 75 },
                new PaymentModel { Label = "time", HourLimit = 0, HourlyRate = 50 }
            };
        }
    }
}
