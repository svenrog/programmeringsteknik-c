using System;
using System.Collections.Generic;
using TimeSheet.Common.Models;
using TimeSheetCommon;
using TimeSheetCommon.Models;

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

            List <CustomerModel> customers = new List<CustomerModel>();

            foreach (var customer in customers)
            {
                var customerTime = TimeSheetProcessor.CalculateTimeForCostumer(timeSheetEntries, customer.Name);
                SimulateSendingMail(customer, customerTime);
            }

            var timeWorked = TimeSheetProcessor.CalculateRimeWorked(timeSheetEntries);
            List<PaymentModel> payments = new List<PaymentModel>();

            foreach (var paymentModel in payments)
            {
                if (timeWorked > paymentModel.HourLimit)
                {
                    SimulatePayment(paymentModel, timeWorked);
                    break;
                }
            }
            
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
        static void SimulateSendingMail(CustomerModel customer, int hours)
        {
            decimal amountToBill = hours * customer.HourlyRate;

            Console.WriteLine($"Simulating Sending email to {customer.Name}");
            Console.WriteLine($"Your bill is {amountToBill} for the hours worked.");
        }
        static void SimulatePayment(PaymentModel paymentModel, int hours)
        {
            decimal amountToPay = PaymentProcessor.CalculatePayment(paymentModel, hours);

            Console.WriteLine($"You will get paid {amountToPay} for your {paymentModel.Label}");
        }
        static List<TimeSheetEntryModel> GetTimeSheetEntries()
        {
            List<TimeSheetEntryModel> timeSheetEntries = new List<TimeSheetEntryModel>();
            bool continueEntering;
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();

                Console.Write("How long did you do it for (in hours): ");
                int hoursDone = int.Parse(Console.ReadLine());

                TimeSheetEntryModel entry = new TimeSheetEntryModel
                {
                    HoursWorked = hoursDone,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(entry);

                Console.Write("Do you want to enter more time (yes/no):");
                continueEntering = Console.ReadLine().ToLower() == "yes";
                //continueEntering = Console.Readline().Equals("yes", StringComparison.OrdinalIgnoreCase) // funkar också men lättare med ToLower
            }
            while (continueEntering == true);

            return timeSheetEntries;
        }
    }
}
