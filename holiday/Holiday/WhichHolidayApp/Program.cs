using System;

namespace WhichHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string question = "Äter man sill?";

            Console.WriteLine("Vilken svensk högtid?");
            Console.WriteLine("---------------------");

            while (question.Contains("?"))
            {
                Console.WriteLine(question);

                string answer = Console.ReadLine();

                if (!answer.ToUpper().Equals("JA") && !answer.ToUpper().Equals("NEJ") && !question.Equals("Vad köper man?"))
                {
                    Console.WriteLine("Fel. Du måste mata in JA eller NEJ.");
                }
                else if (!answer.ToUpper().Equals("ROSOR") && !answer.ToUpper().Equals("PUMPOR") && question.Equals("Vad köper man?"))
                {
                    Console.WriteLine("Fel. Du måste mata in ROSOR eller PUMPOR.");
                }
                else
                {
                    question = GetQuestion(question, answer.ToUpper());
                }


            }

            Console.WriteLine("Det är " + question + "!");
            Console.ReadLine();
        }
        static string GetQuestion(string question, string choice)
        {
            if (question.Equals("Äter man sill?") && choice.Equals("JA"))
            {
                question = "Dricker man must?";
            }
            else if (question.Equals("Äter man sill?") && choice.Equals("NEJ"))
            {
                question = "Är fika viktigt?";
            }
            else if (question.Equals("Dricker man must?") && choice.Equals("JA"))
            {
                question = "Kollar man TV kl. 15.00?";
            }
            else if (question.Equals("Dricker man must?") && choice.Equals("NEJ"))
            {
                question = "Midsommar";
            }
            else if (question.Equals("Kollar man TV kl. 15.00?") && choice.Equals("JA"))
            {
                question = "Jul";
            }
            else if (question.Equals("Kollar man TV kl. 15.00?") && choice.Equals("NEJ"))
            {
                question = "Påsk";
            }
            else if (question.Equals("Är fika viktigt?") && choice.Equals("JA"))
            {
                question = "Vispgrädde?";
            }
            else if (question.Equals("Är fika viktigt?") && choice.Equals("NEJ"))
            {
                question = "Importerat från USA av köpmän?";
            }
            else if (question.Equals("Vispgrädde?") && choice.Equals("JA"))
            {
                question = "Sylt till?";
            }
            else if (question.Equals("Vispgrädde?") && choice.Equals("NEJ"))
            {
                question = "Kanelbullens dag";
            }
            else if (question.Equals("Sylt till?") && choice.Equals("JA"))
            {
                question = "Våffeldagen";
            }
            else if (question.Equals("Sylt till?") && choice.Equals("NEJ"))
            {
                question = "Fettisdagen";
            }
            else if (question.Equals("Importerat från USA av köpmän?") && choice.Equals("JA"))
            {
                question = "Vad köper man?";
            }
            else if (question.Equals("Importerat från USA av köpmän?") && choice.Equals("NEJ"))
            {
                question = "Är man bakfull?";
            }
            else if (question.Equals("Vad köper man?") && choice.Equals("ROSOR"))
            {
                question = "Alla hjärtans dag";
            }
            else if (question.Equals("Vad köper man?") && choice.Equals("PUMPOR"))
            {
                question = "Halloween";
            }
            else if (question.Equals("Är man bakfull?") && choice.Equals("JA"))
            {
                question = "Kollar man på Ivanhoe?";
            }
            else if (question.Equals("Är man bakfull?") && choice.Equals("NEJ"))
            {
                question = "Vet folk orsaken till firandet?";
            }
            else if (question.Equals("Kollar man på Ivanhoe?") && choice.Equals("JA"))
            {
                question = "Nyårsdagen";
            }
            else if (question.Equals("Kollar man på Ivanhoe?") && choice.Equals("NEJ"))
            {
                question = "Första maj";
            }
            else if (question.Equals("Vet folk orsaken till firandet?") && choice.Equals("JA"))
            {
                question = "Kristi himmelsfärd?";
            }
            else if (question.Equals("Vet folk orsaken till firandet?") && choice.Equals("NEJ"))
            {
                question = "Nationaldagen";
            }

            return question;
=======
            // Implementera följande flödesschema med metoder och användarinmatning
            // https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large

            int value;

            while (GetInput(out value) == false);

            Console.WriteLine($"Finally we got a value {value}");
        }

        static bool GetInput(out int inputValue)
        {
            Console.Write("Enter a number: ");
            try
            {
                string rawInput = Console.ReadLine();
                inputValue = int.Parse(rawInput);

                EnsureValidValue(inputValue);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                inputValue = -1;

                return false;
            }
        }

        static void EnsureValidValue(int value)
        {
            if (value > 1_000_000)
                throw new ArgumentOutOfRangeException("Value cannot be above 1 000 000");
>>>>>>> 4c0a63f21c15e580e41bad7e0d47b9e369ef1841
        }
    }
}