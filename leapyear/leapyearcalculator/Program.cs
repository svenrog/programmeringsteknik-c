using System;

namespace leapyearcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstYear = int.Parse(args[0]);
            int secondYear = int.Parse(args[1]);

            int maxYear = Math.Max(firstYear, secondYear);
            int minYear = Math.Min(firstYear, secondYear);
            int leapYearCount = 0;

            for (int year = minYear; year <= maxYear; year++)
            {
                bool isLeapYear = DateTime.IsLeapYear(year);
                if (isLeapYear)
                {
                    leapYearCount++;
                }
            }
            Console.WriteLine($"Det är {leapYearCount} skottår mellan {minYear} och {maxYear}.");
            //Console.Write("Skriv in två olika årtal:\nÅr ett: ");
            //int yearOne = Convert.ToInt32(Console.ReadLine());
            //Console.Write("År två: ");
            //int yearTwo = Convert.ToInt32(Console.ReadLine());

            //if (yearOne < yearTwo)
            //{
            //    leapYearCounter(yearOne, yearTwo);
            //} 
            //else 
            //{
            //    leapYearCounter(yearTwo, yearOne);
            //}
        }
        //public static void leapYearCounter(int firstYear, int secondYear)
        //{
        //    int leapYearCount = 0;
        //    for (int i = firstYear; i < secondYear; i++)
        //    {
        //        if (DateTime.IsLeapYear(i))
        //            leapYearCount++;
        //    }
        //    Console.WriteLine($"Det har varit {leapYearCount} skottår mellan {firstYear} och {secondYear}");
        //}
    }
}
