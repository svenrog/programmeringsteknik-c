using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Common.Models;

namespace TimeSheet.Common.Data
{
    public class CustomerLibrary
    {
        public static List<CustomerModel> GetCustomers()
        {
            return new List<CustomerModel>
            {
                new CustomerModel { Name = "Acme", HourlyRate = 150 },
                new CustomerModel { Name = "ABC", HourlyRate = 125 }
            };
        }
    }
}
