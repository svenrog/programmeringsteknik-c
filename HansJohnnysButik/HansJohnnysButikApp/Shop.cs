using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButikApp
{
    public static class Shop
    {
        public static int ZipCodeing { get; set; }
        public static int ZipCodeBilling { get; set; }       
        public static string CityName { get; set; }
        public static string BillingAdress { get; set; }
        public static string VisitingAdress { get; set; }
        public static string WelcomeMessage { get; set; }

        public static List<Albums> AlbumList = new List<Albums>();
        public static List<Songs> SongList = new List<Songs>();
        public static List<Movies> MovieList = new List<Movies>();
        //public static List<Media> MediaList = new List<Media>();
        //public static List<MediaReader> mediaReaders = new List<MediaReader>();

        public static string PrintVisitingAdress()
        {            
            return $"___________________\n   Besöks adress:\n   {VisitingAdress}\n   {ZipCodeing}\n   {CityName}\n___________________";
        }
        public static string PrintBillingAdress()
        {
            return $"___________________\n   Faktureringsadress:\n{BillingAdress}\n{ZipCodeBilling}\n{CityName}\n___________________";
        }
        public static string PrintBothAdresses()
        {
            return $"Besöksadress:           Faktureringsadress:\n" +
                $"{VisitingAdress} {BillingAdress, 26}\n" +
                $"{ZipCodeing} {ZipCodeBilling, 23}\n" +
                $"{CityName} {CityName, 23}\n" +
                $"________________________________________________________________________________";
        }
        public static string WelcomeToTheShop()
        {
            return $"Hej och hjärtligt välkommen till Hans-Jhonny's suveräna konsol-app butik.\n" +
                   $"Jag är en stor musikälskare som har samlat ihop ett stort antal udda album \n" +
                   $"som inte går att få tag på någon annanstans. \n" +
                   $"meningen är att du skall kika på vad jag erbjuder i butiken, sen ska du pallra \n" +
                   $"dig hit och handla i butiken.\n" +
                   $"Våran policy är direkt kundkontakt, så kika runt och kom sedan hit.\n" +
                   $"\nVäl mött!\n" +
                   $"Hans-Johnny.\n" +
                   $"________________________________________________________________________________\n";
        }
    }
}
