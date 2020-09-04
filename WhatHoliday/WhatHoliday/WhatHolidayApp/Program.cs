using System;
using System.Globalization;

namespace WhatHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questionArray = new string[]
            {
             "Äter man sill?", //0
             "Dricker man must?", //00
             "Är fika viktigt?", //01
             "Kollar man TV kl. 15?", //000
             "Midsommar", // 001
             "Vispgrädde?", // 010
             "Importerat från USA av köpmän?" //011
             };
            string[,] answer = new string[questionArray.Length, 2];
            int[,] links = new int [,]

            Console.WriteLine("Vilken högtid är det?");
            

           
            static bool GetAnswer(string question)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "ja") return true;
                else return false;
            }
        }
    }
}
