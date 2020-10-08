using System;

namespace leapyearcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv in årtal");
                int year1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in andra årtal");
                int year2 = Convert.ToInt32(Console.ReadLine());
                
                if (year1 < year2)
                {
                    leapYearCounter(year1, year2);
                }
                else
                {
                    leapYearCounter(year2, year1);
                }
            }
        }
        public static void leapYearCounter(int item1, int item2)
        {
            int leapYearCount = 0;
            for (int i = item1; i < item2; i++)
            {
                if (DateTime.IsLeapYear(i))
                    leapYearCount++;
            }
            Console.WriteLine($"Det är {leapYearCount} skåttår mellan år {item1} och år {item2}");
        }
    }
}
