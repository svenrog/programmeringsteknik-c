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
            List<CustomerModel> customers = CustomerRepository.GetCustomers();

            foreach (var customer in customers)
            {
                var customerTime = TimeSheetProcessor.CalculateTimeForCustomer(timeSheetEntries, customer.Name);
                SimulateSendingMail(customer, customerTime);
            }

<<<<<<<<< Temporary merge branch 1
            List<PaymentModel> payments = PaymentLibrary.GetPayments();
=========
            List<PaymentModel> payments = PaymentRepository.GetPayments();
>>>>>>>>> Temporary merge branch 2

            var timeWorked = TimeSheetProcessor.CalculateTimeWorked(timeSheetEntries);
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

<<<<<<<<< Temporary merge branch 1
                TimeSheetEntryModel entry = new TimeSheetEntryModel
                { 
=========
                TimeSheetEntryModel entry = new TimeSheetEntryModel()
                {
>>>>>>>>> Temporary merge branch 2
                    HoursWorked = hoursDone,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(entry);

<<<<<<<<< Temporary merge branch 1
                Console.Write("Do you want to enter more time (yes/no):");
=========
                Console.Write("Do you want to enter more time (Yes/No):");
                //continueEntering = Console.ReadLine().ToLower() == "yes";
>>>>>>>>> Temporary merge branch 2
                continueEntering = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);
            }
            while (continueEntering == true);

            return timeSheetEntries;
        }

        static void SimulatePayment(PaymentModel paymentModel, int hours)
        {
<<<<<<<<< Temporary merge branch 1
            decimal amountToPay = PaymentProcessor.CalculatePayment(paymentModel, hours);
=========
            decimal amountToPay = PaymentProcessor.ClaculatePayment(paymentModel, hours);
>>>>>>>>> Temporary merge branch 2

            Console.WriteLine($"You will get paid ${amountToPay} for your {paymentModel.Label}.");
        }

        static void SimulateSendingMail(CustomerModel customer, int hours)
        {
            decimal amountToBill = hours * customer.HourlyRate;

            Console.WriteLine($"Simulating Sending email to {customer.Name}");
            Console.WriteLine($"Your bill is ${amountToBill} for the hours worked.");
<<<<<<<<< Temporary merge branch 1
=========

>>>>>>>>> Temporary merge branch 2
        }
    }
}
