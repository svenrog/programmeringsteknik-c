using System;
using System.Collections.Generic;
using System.Text;

namespace WhichHolidayApp
{
    class Sill
    {
        public static void Run() // Gren 0
        {          
            string input = "";

            while (input != "n" && input != "j")
                {
                Console.WriteLine("Äter man sill ? svara med ett n eller j");
                input = Console.ReadLine();
                }

            if (input == "n")
            {
                FikaViktigt();
            }
            else
            {
                DrickaMust();
            }
        }

        static void DrickaMust() // Gren 1
        {
            Console.WriteLine("Dricker man must ? svara med ett n eller j");
            string input = "";
            do
            {
                input = Console.ReadLine();
            }
            while (input != "n" && input != "j");

            if (input == "n")
            {
                Console.WriteLine("Det är midsommar!");
            }
            else
            {
                SeTv();
            }
        }

        static void FikaViktigt() // Gren 1
        {
            Console.WriteLine("Är fika viktigt ? svara med ett n eller j");
            string input = "";
            do
            {
                input = Console.ReadLine();
            }
            while (input != "n" && input != "j");

            if (input == "n")
            {
                // Anrop Importerat av köpman från USA
            }
            else
            {
                WhipCream();
            }
        }

        static void SeTv() // Gren 2
        {
            Console.WriteLine("Tittar man på tv kl 15:00 ? svara med ett n eller j");
            string input = "";
            do
            {
                input = Console.ReadLine();
            }
            while (input != "n" && input != "j");

            if (input == "n")
            {
                Console.WriteLine("Det är påsk!");
            }
            else
            {
                Console.WriteLine("Det är jul!");
            }
        }

        static void WhipCream() // Gren 2
        {
            Console.WriteLine("Vispgrädde ? svara med ett n eller j");
            string input = "";
            do
            {
                input = Console.ReadLine();
            }
            while (input != "n" && input != "j");

            if (input == "n")
            {
                Console.WriteLine("Det är kanelbullens dag!");
            }
            else
            {
                SyltVal();
            }
        }

        static void SyltVal()
        {
            Console.WriteLine("Sylt ? svara med ett n eller j");
            string input = "";
            do
            {
                input = Console.ReadLine();
            }
            while (input != "n" && input != "j");

            if (input == "n")
            {
                Console.WriteLine("Det är fettisdagen!");
            }
            else
            {
                Console.WriteLine("Det är våffeldagen!");
            }
        } // Gren 3
    }
}
