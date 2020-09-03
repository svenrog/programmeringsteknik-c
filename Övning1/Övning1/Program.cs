using Microsoft.VisualBasic;
using System;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Namn och ålder.";
            UserName();
            AgeCheck();
            AgeGuesses();

            Console.WriteLine("Tryck valfri tangent för att avsluta...");
            Console.ReadKey(true);
        }
        static void UserName()
        {
            string strFirstName, strSurName, strUserName;
            int intIndexForBlank;

            Console.WriteLine("Hej vänligen skriv in ditt namn!");
            strUserName = Console.ReadLine();

            intIndexForBlank = strUserName.IndexOf(" ");

            strFirstName = strUserName.Substring(0, intIndexForBlank);
            strSurName = strUserName.Substring(intIndexForBlank + 1);

            Console.WriteLine($"Hej! {strFirstName} {strSurName}");
        }
        static void AgeCheck()
        {
            int intUserAge = 0;
            bool boolTry = false;

            Console.WriteLine("Skriv in din ålder");

            do
            {
                try
                {
                    intUserAge = Convert.ToInt32(Console.ReadLine());
                    boolTry = true;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Wrong format! Please use numbers only.");
                }
            } while (boolTry == false);

            Console.WriteLine($"Du är {intUserAge} år.");
        }
        static void AgeGuesses()
        {
            int intMyAge = 48;
            int intUserGuess = 0;
            bool boolTry = false;

            Console.WriteLine("Gissa hur gammal jag är!");

            do
            {
                try
                {
                    intUserGuess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format! Please use numbers only. Gissa igen!");
                }

                if (intUserGuess == intMyAge)
                {
                    Console.WriteLine("Jepp! Du gissade rätt!");
                    boolTry = true;
                }
                else if (intUserGuess <= 17 && intUserGuess >= 1)
                {
                    Console.WriteLine("Nädu! Jag är inget barn! Gissa igen.");
                }
                else if (intUserGuess <= 26 && intUserGuess >= 18)
                {
                    Console.WriteLine("Oj! Hur mycket vill du låna? Gissa igen.");
                }
                else if (intUserGuess <= 47 && intUserGuess >= 27)
                {
                    Console.WriteLine("Inte riktigt så ung! Gissa igen.");
                }
                else if (intUserGuess <= 65 && intUserGuess >= 49)
                {
                    Console.WriteLine("Nä! Jag har inte klivit över döhalvan i livet. Gissa igen.");
                }
                else if (intUserGuess <= 100 && intUserGuess >= 66)
                {
                    Console.WriteLine("Nä! Jag är inte pensionär Gissa igen.");
                }
                else if (intUserGuess >= 101)
                {
                    Console.WriteLine("Tyvärr! Ålder över 100 är orimligt! Gissa igen.");
                }
            } while (boolTry == false);
        }
    }
}
