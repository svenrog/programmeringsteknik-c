using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WhichHolidayApp
{
    static class Menu
    {
        //Just skip this code for now
        public static string fatLine = "================================================================================";
        public static List<string> options = new List<string> { "Yes", "No" };
        public static void ClearLastLine(int amountOfLineToClear = 0)
        {
            for (int i = 0; i < amountOfLineToClear; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - (Console.WindowWidth >= Console.BufferWidth ? 1 : 0));
            }
        }
        public static string Display(string input, List<string> menuOption)
        {
            int index = 0;//reset

            try
            {
                while (true)
                {
                    Console.WriteLine("\n" + input);
                    Console.CursorVisible = false; Console.WriteLine(fatLine); //Visar ingen markering samt ny rad + linje
                    for (int i = 0; i < menuOption.Count; i++)
                    {
                        if (i == index) //"Lyser upp" listelementet man nuvarande befinner sig på
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(menuOption[i]);
                        }
                        else Console.WriteLine(menuOption[i]); //Annars skrivs övriga element skrivs ut som vanligt
                        Console.ResetColor();
                    }
                    ConsoleKeyInfo Ckey = Console.ReadKey();//Detekterar tangenttrycket
                    switch (Ckey.Key) //Utvärderar tangenttrycket
                    {
                        case ConsoleKey.Enter:
                            int indexToReturn = index; index = 0; //Nollställer index efter metoden returnerats
                            return menuOption[indexToReturn];
                        case ConsoleKey.DownArrow:
                            if (index != menuOption.Count - 1) index++; break;
                        case ConsoleKey.UpArrow:
                            index = (index <= 0) ? index : --index; break;
                        case ConsoleKey.Escape: return null;
                        default: break;
                    }
                    //Console.Clear();
                    ClearLastLine(menuOption.Count); //Rensar alla rader listans element har skrivits ut på
                    continue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

    }
    class Program
    {
        //Tänk från andra hållet i stället. Utgå från frågorna och var de skall leda. 
        //Min lösning innehåller en Array av typen ValueTuple som håller all data (fråga, alternativ, länkar)

        //Behöver hjälp med att göra ValueTuple snyggare som att inte behöva skriva item, eventuellt hur man länkar till en annan typ av ValueTuple
        //Då det lätt blir rörigt med många int som index stickspår
        //Skall man eventuellt ha svaret: högtiden som en länk istället, göra om int länken till en string,
        //Typ checka om länk inten inte är ett nummer så skriver man ut högtiden
        //Tacksam för feedback, sjukt kul och jobba med tuples för övrigt men vill att det ska bli bra från början till slut.

        //Just here for copying the questions to an ValueTuple collection
        //string[] querys = new string[] { "Do we eat herring?",
        //                                "Do we drink must?",
        //                                "Are we watching television at 15.00 AM?",
        //                                "Does fika plays a big roll in it ?",
        //                                "Whipped cream?",
        //                                "Jam with it?",
        //                                "Are we hangover?",
        //                                "Do people know the cause for celebration?",
        //                                "Imported from USA by merchants?",
        //                                "What do you buy?",
        //                                "Do we watch Ivanhoe?"};
        static void Main(string[] args)
        {
            // Implementera följande flödesschema med metoder och användarinmatning
            // https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large


            //Little nice declaration but cant get into to a collection
            //(string, int, int) isHerring = ("Do we eat herring?", 1, 2);

            //An array is to difficult to initialize
            var queryList = new List<ValueTuple<string, int, int>>
            {      //                                                       y/n
                   new ValueTuple<string, int, int> ("Do we eat herring?", 1, 2),                       //0
                   new ValueTuple<string, int, int> ("Do we drink must??", 3, 5),                       //1
                   new ValueTuple<string, int, int> ("Are we hangover?", 0, 4),                         //2
                   new ValueTuple<string, int, int> ("Are we watching television at 15.00 AM?", 6, 7),  //3
                   new ValueTuple<string, int, int> ("Does fika play a big role?", 8, 0),               //4
                   new ValueTuple<string, int, int> ("\nMidsommar(Midsomer)", 0, 0),                    //5
                   new ValueTuple<string, int, int> ("\nJul(Christmas)", 0, 0),                         //6
                   new ValueTuple<string, int, int> ("\nPåsk(Easter)", 0, 0),                           //7
                   new ValueTuple<string, int, int> ("Whipped cream?", 0, 9),                           //8
                   new ValueTuple<string, int, int> ("\nKanebullensdag(Cinnamonbun day)", 0, 0),        //9
            };

            Console.WriteLine("Ge the Swedish holiday by answering theese questions? (y/n)");
            Console.WriteLine("-----------------------------------------------------------");

            int index = 0;
            while (true)
            {
                var question = queryList[index].Item1;
                var yesRoute = queryList[index].Item2;
                var noRoute = queryList[index].Item3;

                Console.WriteLine(question);
                string input = Console.ReadLine().ToLower();

                if (input[0] == 'y')
                    index = yesRoute;
                else if (input[0] == 'n')
                    index = noRoute;
                else continue;

            }

            //I want the ValueTuple to become shorter and mor describive outputs, just not item1 etc
            //var (question, alternative, link) = GetHoliday(input);

        }
        //Just trying out som stuff

        //static (string question, int alternative, int link) IsHerring(string answer)
        //{

        //    return "";
        //}

        //    static (string question,int alternative, int link) GetHoliday(string answer)
        //    {

        //        return "";
        //    }
    }
}
