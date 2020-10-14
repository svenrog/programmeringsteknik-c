using System;
using System.Collections.Generic;
using TimeSheet.Common;
using TimeSheet.Common.Data;
using TimeSheet.Common.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntryModel> timeSheetEntries = TimeSheetList();
            List<CustomerModel> customers = CustomerRepository.GetCustomerData(timeSheetEntries);

            foreach (CustomerModel customer in customers)
            {
                SimulateSendingEmailToCustomer(customer);
            }

            List<PaymentModel> payments = PaymentRepository.GetPaymentModels();

            int totalTimeWorked = TimeSheetProcessor.CalculateWorkedHours(timeSheetEntries);
            foreach (PaymentModel model in payments)
            {
                if (totalTimeWorked > model.HourLimit)
                {
                    SimulatePaymentOutput(model, totalTimeWorked);
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }



        public static void SimulateSendingEmailToCustomer(CustomerModel customer)
        {
            Console.WriteLine($"Simulating Sending email to {customer.Name}");
            Console.WriteLine($"Your bill is ${customer.HoursWorked * customer.HourlyRate} for the hours worked.");
        }

        public static void SimulatePaymentOutput(PaymentModel paymentModel, int hours)
        {
            decimal amountToPay = (hours * paymentModel.HourlyRate);
            Console.WriteLine($"You will get paid ${amountToPay} for your {paymentModel.Label}.");
        }
        public static List<TimeSheetEntryModel> TimeSheetList()
        {
            List<TimeSheetEntryModel> timeSheetEntries = new List<TimeSheetEntryModel>();

            bool continueLoop;
            do
            {
                Console.Write("Enter what you did: ");
                string workInput = Console.ReadLine();

                Console.Write("For how many hours did you work?");
                int timeInput = int.Parse(Console.ReadLine());

                TimeSheetEntryModel entry = new TimeSheetEntryModel
                {
                    HoursWorked = timeInput,
                    WorkDone = workInput
                };
                timeSheetEntries.Add(entry);

                Console.Write("Do you want to make further entries? (y/n)");
                continueLoop = Console.ReadLine().Contains("y");

            } while (continueLoop);

            return timeSheetEntries;
        }
    }
}
