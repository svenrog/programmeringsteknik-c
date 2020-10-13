using System;
using System.Collections.Generic;
using TimeSheet.Common;
using TimeSheet.Common.Data;
using TimeSheet.Common.Models;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntryModel> timeSheetEntries = GetTimeSheetEntries();
            List<CustomerModel> customers = CustomerLibrary.GetCustomers();

            foreach (var customer in customers)
            {
                var customerTime = TimeSheetProcessor.CalculateTimeForCustomer(timeSheetEntries, customer.Name);
                SimulateSendingMail(customer, customerTime);
            }

            List<PaymentModel> payments = PaymentLibrary.GetPayments();

            var timeWorked = TimeSheetProcessor.CalculateTimeWorked(timeSheetEntries);
            foreach (var payment in payments)
            {
                if (timeWorked > payment.HourLimit)
                {
                    SimulatePayment(payment, timeWorked);
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntryModel> GetTimeSheetEntries()
        {
            bool continueEntering;
            List<TimeSheetEntryModel> timeSheetEntries = new List<TimeSheetEntryModel>();
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();

                Console.Write("Enter how many hours you did it for: ");
                int hoursDone = int.Parse(Console.ReadLine());

                TimeSheetEntryModel entry = new TimeSheetEntryModel
                {
                    HoursWorked = hoursDone,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(entry);

                Console.Write("Do you want to enter more time (yes/no): ");
                continueEntering = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);
            }
            while (continueEntering == true);

            return timeSheetEntries;
        }

        static void SimulatePayment(PaymentModel paymentModel, int hours)
        {
            decimal hourlyRate = 50;
            decimal hourlyRateExtra = 75;
            decimal amountToPay = 0;

            if (hours > 40)
            {
                amountToPay = hourlyRate * 40;
                hours =- 40;
                amountToPay += hours * hourlyRateExtra;
            }
            else
            {
                amountToPay = hours * hourlyRate;
            }

            Console.WriteLine($"You will get paid ${amountToPay} for your {paymentModel.Label}");
        }

        static void SimulateSendingMail(CustomerModel customer, int hours)
        {
            decimal amountToBill = hours * customer.HourlyRate;

            Console.WriteLine($"Simulating Sending email to {customer.Name}");
            Console.WriteLine($"Your bill is ${amountToBill} for the hours worked.");
        }
    }
}
