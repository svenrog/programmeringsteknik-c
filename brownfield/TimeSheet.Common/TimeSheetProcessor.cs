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

            // Blir lätt grötingt om man gör mer komlicerad, men i detta fall fungerar det ypperligt!

            //return entries.Where(e => e.WorkDone.ToLower().Contains(customerName))
            //                 .Sum(e => e.HoursWorked);

            int sum = 0;

            foreach (var entry in entries)
            {
                int customerIndex = entry.WorkDone.IndexOf(customerName, StringComparison.OrdinalIgnoreCase);

                if (customerIndex >= 0)
                {
                    sum += entry.HoursWorked;
                }
            }

            return sum;
        }

        public static int CalculateTimeWorked(List<TimeSheetEntryModel> entries) =>
            entries.Sum(x => x.HoursWorked);
        //{

        ////    //int sum = 0;

        ////    //foreach (var entry in entries)
        ////    //{
        ////    //    sum += entry.HoursWorked;
        ////    //}

        ////    //return sum;

        //    return entries.Sum(x => x.HoursWorked);
        //}
    }
}
