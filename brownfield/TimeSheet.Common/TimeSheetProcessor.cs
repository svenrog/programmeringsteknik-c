using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheet.Common.Models;

namespace TimeSheet.Common
{
    public class TimeSheetProcessor
    {
        public static int CalculateTimeForCustomer(List<TimeSheetEntryModel> entries, string customerName)
        {
            int sum = 0;
            foreach (var entry in entries)
            {
                //int customerIndex = entry.WorkDone.IndexOf(customerName, StringComparison.OrdinalIgnoreCase);
                //entries.Where(e => e.WorkDone.ToLower().Contains(customerName))
                //        .Sum(e => e.HoursWorked);

                if (entry.WorkDone.Contains(customerName)) // entry.WorkDone.Contains(customerName
                {
                    sum += entry.HoursWorked;
                }
            }
                
            return sum;
        }
        public static int CalculateTimeWorked(List<TimeSheetEntryModel> entries) => 
            entries.Sum(x => x.HoursWorked);
        //public static int CalculateTimeWorked(List<TimeSheetEntryModel> entries)
        //{
        //    int sum = 0;
        //    foreach (var entry in entries)
        //    {
        //        sum += entry.HoursWorked;
        //    }

        //    return sum;
        //    //return entries.Sum(x => x.HoursWorked);
        //}
        public static int CalculateTimeAsLambda(List<TimeSheetEntryModel> e, string c) =>
            e.Where(x => x.WorkDone.ToLower().Contains(c))
            .Sum(x => x.HoursWorked);
    }
}
