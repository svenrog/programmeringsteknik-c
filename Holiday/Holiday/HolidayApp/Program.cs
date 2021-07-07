using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.IO;

namespace HolidayApp
{
    class Program
    {
        public List<bool> inputTrueOrFalse = new List<bool>();

        //frågar om input, svarar true för "ja" och false för "nej"
        public bool ReadInput()
        {
            string input = null;
            while (input != "ja" && input != "nej")
            {
                Console.Write("Svara med \"ja\" eller \"nej\"\n\n");
                input = Console.ReadLine();
            }
            if (input == "ja")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Sparar input i en array för att jämföra i textlistan
        public bool[] AddToArray(bool input)
        {
            inputTrueOrFalse.Add(input);
            bool[] boolArray = inputTrueOrFalse.ToArray();
            return boolArray;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            #region Dictionary
            Dictionary<string, bool[]> TextList = new Dictionary<string, bool[]>();
            TextList.Add("Äter man sill?", new bool[] { false });
            TextList.Add("Dricker man must?", new bool[] { false, true });
            TextList.Add("Är fika viktigt?", new bool[] { false, false });
            TextList.Add("Kollar man Tv kl.15.00?", new bool[] { false, true, true });
            TextList.Add("Midsommar", new bool[] { false, true, false });
            TextList.Add("Jul", new bool[] { false, true, true, true });
            TextList.Add("Påsk", new bool[] { false, true, true, false });
            TextList.Add("Vispgrädde?", new bool[] { false, false, true });
            TextList.Add("Importerat från Usa av köpmän?", new bool[] { false, false, false });
            TextList.Add("Sylt till?", new bool[] { false, false, true, true });
            TextList.Add("Kanelbullens dag", new bool[] { false, false, true, false });
            TextList.Add("Våffeldagen", new bool[] { false, false, true, true, true });
            TextList.Add("Fettisdagen", new bool[] { false, false, true, true, false });
            TextList.Add("Vad köper man?", new bool[] { false, false, false, true });
            TextList.Add("Är man bakfull?", new bool[] { false, false, false, false });
            TextList.Add("Alla hjärtans dag", new bool[] { false, false, false, true, true });
            TextList.Add("Halloween", new bool[] { false, false, false, true, false });
            TextList.Add("Kollar man på Ivanhoe?", new bool[] { false, false, false, false, true });
            TextList.Add("Vet folk orsaken till firandet?", new bool[] { false, false, false, false, false });
            TextList.Add("Nyårsdagen", new bool[] { false, false, false, false, true, true });
            TextList.Add("Första Maj", new bool[] { false, false, false, false, true, false });
            TextList.Add("Kristi himmelsfärd", new bool[] { false, false, false, false, false, true });
            TextList.Add("National-dagen", new bool[] { false, false, false, false, false, false });
            #endregion

            bool[] boolArray = new bool[] { };

            boolArray = program.AddToArray(false);

            //går igenom varje sträng och kontrollerar vilken fråga vi är på baserat på ja eller nej svar

            foreach (KeyValuePair<string, bool[]> text in TextList)
            {

                bool isEqual = Enumerable.SequenceEqual(text.Value, boolArray);

                while (isEqual)
                {
                    if (!text.Key.Contains("?"))
                    {
                        Console.WriteLine("Högtiden du tänker på är: " + text.Key);
                        goto End;
                    }
                    Console.WriteLine(text.Key + "\n");
                    boolArray = program.AddToArray(program.ReadInput());
                    isEqual = Enumerable.SequenceEqual(text.Value, boolArray);
                    Console.Clear();
                }
            }
        End:
            Console.ReadKey();
        }
    }
}
