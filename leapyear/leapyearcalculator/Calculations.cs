using System;
using System.Collections.Generic;
using System.Text;

namespace leapyearcalculator
{
    class Calculations
    {
        public int CalcLeap(int start, int end)
        {
            int result = 0;
            while (start <= end)
            {
                if (DateTime.IsLeapYear(start) == true)
                {
                   result++;
                }
                start++;
            }
            return result;
        }
    }
}
