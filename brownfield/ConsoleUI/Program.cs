using System;
using System.Collections.Generic;
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
            string workDone;
            int i;
            int hoursDone; 
            int timeTotal;

            List<TimeSheetEntryModel> timeSheetEntries = new List<TimeSheetEntryModel>();

            bool continueEntering;
            do
            {
                Console.Write("Enter what you did: ");
                workDone = Console.ReadLine();

                Console.Write("Enter how many hours you did it for: ");
                hoursDone = int.Parse(Console.ReadLine());

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

            timeTotal = 0;
            for (i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.Contains("Acme"))
                {
                    timeTotal += i;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + timeTotal * 150 + " for the hours worked.");
            for (i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.Contains("ABC"))
                {
                    timeTotal += i;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + timeTotal * 125 + " for the hours worked.");
            for (i = 0; i < timeSheetEntries.Count; i++)
            {
                timeTotal += timeSheetEntries[i].HoursWorked;
            }
            if (timeTotal > 40)
            {
                Console.WriteLine("You will get paid $" + timeTotal * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + timeTotal * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }
}
