using System;

namespace SecondsConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunder = 1_262_332_654;
            int ejheladagar = sekunder % 86400;
            int dagar = (sekunder - ejheladagar) / 86400;
            int ejhelatimmar = ejheladagar % 3600;
            int timmar = (ejheladagar - ejhelatimmar) / 3600;
            int ejhelaminuter = ejhelatimmar % 60;
            int minuter = (ejhelatimmar - ejhelaminuter) / 60;
            int secunder = ejhelaminuter;
            Console.WriteLine($"{sekunder} sekunder är {dagar} dagar, {timmar} timmar, {minuter} minuter, {secunder} sekunder");
        }
    }
}
