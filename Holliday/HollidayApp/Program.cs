using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace HollidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Holliday App";

            Console.WriteLine("Välkommen! Nu tar vi reda på vilken högtid du firar. För att svara på frågorna så använd j eller n. \nDu kan komma att behöva skriva in ett ord för att svara.\n");

            CheckHarringAnswer();

            Console.WriteLine("\nPress any key to exit program...!");
            Console.ReadKey(true);
        }

        static string CheckUserAnswer()
        {
            string enteredString = "";
            string lowerCaseString = "";
            bool correctWord = true;

            do
            {
                enteredString = Console.ReadLine().ToLower();
                lowerCaseString = enteredString;
                if (lowerCaseString == "j" || lowerCaseString == "n" || lowerCaseString == "pumpor" || lowerCaseString == "rosor")
                {
                    correctWord = true;
                }
                else
                {
                    correctWord = false;
                    Console.WriteLine("Vänligen svara med j, n eller genom att skriva in ett ord. Du kanske stavade fel?");
                }
            } while (correctWord == false);

            return lowerCaseString;
        }

        static void CheckHarringAnswer()
        {
            Console.WriteLine("Äter man sill?");
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Dricker man must?");
                CheckMustAnswer();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Är fika viktigt?");
                CheckFikaAnswer();
            }
        }

        static void CheckMustAnswer()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Kollar man på TV kl.15:00?");
                CheckTvAnswer();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar midsommar!");
            }
        }

        static void CheckTvAnswer()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Du firar jul!");
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar påsk!");
            }
        }
        static void CheckFikaAnswer()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Vispgrädde?");
                CheckVispGradde();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Importerat från USA av köpmän?");
                CheckUsaImport();
            }
        }
        static void CheckVispGradde()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Sylt till?");
                CheckJamAnswer();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar Kanelbullensdag!");
            }
        }
        static void CheckJamAnswer()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Du firar våffeldagen!");
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar fettisdagen!");
            }
        }
        static void CheckUsaImport()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Här skall du skriva hela ordet. \nKöper man rosor eller pumpor?");
                CheckPurchase();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Är man bakfull?");
                CheckHangover();
            }
        }

        static void CheckPurchase()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "rosor")
            {
                Console.WriteLine("Du firar alla hjärtans dag!");
            }
            else if (userAnswer == "pumpor")
            {
                Console.WriteLine("Du firar halloween!");
            }
        }
        static void CheckHangover()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Kollar man på Ivanhoe?");
                CheckIvanhoe();
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Vet folk anledningen till firandet?");
                CheckCelebration();
            }
        }
        static void CheckIvanhoe()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Du firar Nyårsdagen!");
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar första maj!");
            }
        }
        static void CheckCelebration()
        {
            string userAnswer = CheckUserAnswer();

            if (userAnswer == "j")
            {
                Console.WriteLine("Du firar kristihimmelsfärd!");
            }
            else if (userAnswer == "n")
            {
                Console.WriteLine("Du firar Nationaldagen!");
            }
        }
    }
}
