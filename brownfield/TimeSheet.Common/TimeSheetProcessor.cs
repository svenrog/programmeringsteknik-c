using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Common.Models;

namespace TimeSheet.Common
{
    public static class TimeSheetProcessor
    {
        public static int CalculateTimeForCustomer(List<TimeSheetEntryModel> entries, string customerName)
        {
            int timeSum = 0;

            for (int i = 0; i < entries.Count; i++)
            {
                if (entries[i].WorkDone.ToLower().Contains(customerName.ToLower()))
                {
                    timeSum += entries[i].HoursWorked;
                }
            }
            return timeSum;
        }

        public static int CalculateWorkedHours(List<TimeSheetEntryModel> entries) => 
                                                                        entries.Sum(x => x.HoursWorked);
    }
}
