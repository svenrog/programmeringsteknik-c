using System;
using System.Collections.Generic;
using System.Globalization;

namespace months
{
    class Program
    {
        static Dictionary<int, string> months = new Dictionary<int, string> { { 1, "Januari" }, { 2, "Februari" }, { 3, "Mars" }, { 4, "April" }, { 5, "Maj" }, { 6, "Juni" }, 
            { 7, "Juli" }, { 8, "Augusti" }, { 9, "September" }, { 10, "Oktober" }, { 11, "November" }, { 12, "December" } };
        static void Main(string[] args)
        {
            // Skriv ett program som tar en emot inmatad siffra (1-12)
            // och konverterar siffran till ett månadsnamn på svenska
            // programmet skall kasta ett fel om den inmatade siffran är något annat än 1-12.

            Console.WriteLine("Vänligen skriv in en siffra, heltal, fr.o.m. 1 t.o.m. 12, utan något annat tecken, för att få ut motsvarande månad.");
            int input = Test.Input();
            Console.WriteLine(months[input]);

            Console.WriteLine(DateTime.Parse($"1900-{input}-01").Month);
            
        }
    }
}
