using System.Collections.Generic;

namespace TimeSheetCommon.Data
{
    public class CustomerLibrary
    {

        public static List<CustomerModel> GetCustomers()
        {
            return new List<CustomerModel>
            {
                new CustomerModel { Name = "Acme", HourlyRate = 150 },      // Funkar med customers.Add(Name = "Acme", HourlyRate = 150)
                new CustomerModel { Name = "ABC", HourlyRate = 125 }
            };
        }
    }
}
