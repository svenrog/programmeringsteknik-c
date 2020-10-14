
using System.Collections.Generic;
using TimeSheet.Common.Models;

namespace TimeSheet.Common.Data
{
    public class CustomerRepository
    {
        public static List<CustomerModel> GetCustomerData(List<TimeSheetEntryModel> timeSheetEntries)
        {
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel(),
                new CustomerModel()
            };
            string[] customerNames = new string[] { "Acme", "ABC" };
            int[] customerHourlyRates = new int[] { 150, 125 };
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].Name = customerNames[i];
                customers[i].HourlyRate = customerHourlyRates[i];
                customers[i].HoursWorked = TimeSheetProcessor.CalculateTimeForCustomer(timeSheetEntries, customers[i].Name);
            }
            return customers;
        }
    }
}
