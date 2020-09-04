//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WhichHolidayApp
//{
//    abstract class Holidays
//    {
//        //I dont want to make them default = false
//        public Holidays(bool _herring = false, bool _must = false, bool _donaldDuck = false, bool _fika = false, bool _whippedCream = false,  bool _jam = false, bool _usImport = false, bool _hangover = false, bool _ivanhoe = false, bool _dunno = false)
//        {
//            Herring = _herring;
//            Must = _must;
//            DonaldDuck = _donaldDuck;
//            Fika = _fika;
//            WhippedCream = _whippedCream;
//            Jam = _jam;
//            USImport = _usImport;
//            Hangover = _hangover;
//            Ivanhoe = _ivanhoe;
//            Dunno = _dunno;//Do not know the cause for celebrating

//        }
//        public  bool Herring { get; private set; }
//        public  bool Must { get; private set; }
//        public  bool DonaldDuck { get; private set; }
//        public  bool Fika { get; private set; }
//        public  bool WhippedCream { get; private set; }
//        public  bool Jam { get; private set; }
//        public  bool USImport { get; private set; }
//        public  bool Hangover { get; private set; }
//        public  bool Ivanhoe { get; private set; }
//        public  bool Dunno { get; private set; }

//    }
//    sealed class  Midsommer : Holidays
//    {
//        public Midsommer//Dont want so much inparamaters and base parameters, just need to in inheritage herringbool
//            (bool _herring = true, bool _must, bool _donaldDuck, bool _fika, bool _whippedCream,
//            bool _jam, bool _usImport, bool _hangover, bool _ivanhoe, bool _dunno) :
//            base(_herring, _must, _donaldDuck, _fika, _whippedCream, _jam, _usImport, _hangover, _ivanhoe, _dunno)
//        {
//            _herring = true;
//        }
//    }
//    sealed class Christmas : Holidays
//    {
//        public Christmas
//            (bool _herring, bool _must, bool _donaldDuck, bool _fika, bool _whippedCream,
//            bool _jam, bool _usImport, bool _hangover, bool _ivanhoe, bool _dunno) :
//            base(_herring, _must, _donaldDuck, _fika, _whippedCream, _jam, _usImport, _hangover, _ivanhoe, _dunno)
//        {
//            _herring = true;
//            _must = true;
//            _donaldDuck = true;
//        }
//    }
//    sealed class Easter : Holidays
//    {
//        public Easter
//            (bool _herring, bool _must, bool _donaldDuck, bool _fika, bool _whippedCream,
//            bool _jam, bool _usImport, bool _hangover, bool _ivanhoe, bool _dunno) :
//            base(_herring, _must, _donaldDuck, _fika, _whippedCream, _jam, _usImport, _hangover, _ivanhoe, _dunno)
//        {
//            _herring = true;
//            _must = true;
//        }
//    }
//    sealed class CinnamonBunDay : Holidays
//    {
//        public CinnamonBunDay
//            (bool _herring, bool _must, bool _donaldDuck, bool _fika, bool _whippedCream,
//            bool _jam, bool _usImport, bool _hangover, bool _ivanhoe, bool _dunno) :
//            base(_herring, _must, _donaldDuck, _fika, _whippedCream, _jam, _usImport, _hangover, _ivanhoe, _dunno)
//        {
//            _fika = true;

//        }
//    }
//    sealed class WaffleDay : Holidays
//    {
//        public WaffleDay
//            (bool _herring, bool _must, bool _donaldDuck, bool _fika, bool _whippedCream,
//            bool _jam, bool _usImport, bool _hangover, bool _ivanhoe, bool _dunno) :
//            base(_herring, _must, _donaldDuck, _fika, _whippedCream, _jam, _usImport, _hangover, _ivanhoe, _dunno)
//        {
//            _fika = true;
//            _whippedCream = true;
//            _jam = true;
//        }
//    }
//}


//while (true)
//{
//    input = Menu.Display("Do we eat harring?", Menu.options);
//    if (input == "Yes")
//    {
//        input = Menu.Display("Do we drink must?", Menu.options);
//        if (input == "Yes")
//        {

//            input = Menu.Display("Are we watching television at 15.00 AM?", Menu.options);
//            Console.WriteLine();
//            Console.WriteLine((input == "Yes") ? "Jul" : "Midsommar");
//        }
//        else Console.WriteLine("\nMidsommar!");
//    }
//    else if (input == "No")
//    {
//        input = Menu.Display("Does fika plays a big roll in it?", Menu.options);
//        if (input == "Yes")
//        {
//            input = Menu.Display("Whipped cream?", Menu.options);
//            Console.WriteLine();
//            Console.WriteLine((input == "Yes") ? "Våffeldagen!" : "Fettisdagen");
//        }
//        else Console.WriteLine("\nKanelbullensdag!");
//    }
//}