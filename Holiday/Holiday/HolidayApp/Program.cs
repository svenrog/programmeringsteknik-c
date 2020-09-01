using System;
using System.Runtime.CompilerServices;

namespace HolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken svensk högtid?");

            var input = Console.ReadLine();

            //var question = "";

            //true / false eller 1 / 0 ??
            bool answer = true;
            int[,] answersArray = new int[1, 0];

            string[] holidaysArray = new string[11];

            string[] questionArray = new string[10];

            #region Answers
            holidaysArray[0] = "Jul";
            holidaysArray[1] = "Påsk";
            holidaysArray[2] = "Midsommar";
            holidaysArray[3] = "Våffeldagen";
            holidaysArray[4] = "Fettisdagen";
            holidaysArray[5] = "Kanelbullens dag";
            holidaysArray[6] = "Alla hjärtans dag";
            holidaysArray[7] = "Halloween";
            holidaysArray[8] = "Nyårsdagen";
            holidaysArray[9] = "Första maj";
            holidaysArray[10] = "Kristi himmelsfärd";
            holidaysArray[11] = "National-dagen";
            #endregion

            #region Questions
            questionArray[0] = "Äter man sill?";
            questionArray[1] = "Dricker man must?";
            questionArray[2] = "Kollar man TV kl.15.00?";
            questionArray[3] = "Är fika viktigt?";
            questionArray[4] = "Vispgrädde?";
            questionArray[5] = "Sylt till?";
            questionArray[6] = "Importerat från USA av köpmän?";
            questionArray[7] = "Vad köper man?";
            questionArray[8] = "Är man bakfull?";
            questionArray[9] = "Kollar man på Ivanhoe?";
            questionArray[10] = "Vet folk orsaken till firandet?";
            #endregion

            /*
            static void QuestionAsk(string question)
            {
                Console.WriteLine(question);
            }

            static void QuestionAnswer(bool answer)
            {
                if (answer == true)
                {
                    QuestionAsk();
                }
            }
            */
        }
    }
}
