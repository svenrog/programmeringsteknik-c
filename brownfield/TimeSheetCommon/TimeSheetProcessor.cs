using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheet.Common.Models;

namespace TimeSheetCommon
{
    public class TimeSheetProcessor
    {
        public static int CalculateTimeForCostumer(List<TimeSheetEntryModel> entries, string costumerName)
        {
            int sum = 0;

            //entries.Where(e => e.WorkDone.ToLower().Contains(costumerName)) Funkar med LINQ då lösningen är enkel...
            //       .Sum(e => e.HoursWorked);                                ...som denna lösning.

            foreach (var entry in entries)
            {
                int costumerIndex = entry.WorkDone.IndexOf(costumerName, StringComparison.OrdinalIgnoreCase);
                if (costumerIndex >= 0)
                {
                    sum += entry.HoursWorked;
                }
            }
            return sum;
        }
        public static int CalculateRimeWorked(List<TimeSheetEntryModel> entries) =>
            entries.Sum(x => x.HoursWorked);
        //{
        //    int sum = 0;

        //    foreach (var entry in entries)
        //    {                                         Detta funkar om man inte kör Lambda
        //        sum += entry.HoursWorked;
        //    }

        //    return entries.Sum(x => x.HoursWorked);
        //}
    }
}
