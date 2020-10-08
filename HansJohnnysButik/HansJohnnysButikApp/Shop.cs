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

        public static List<Music> MusicList = new List<Music>();
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
                $"{CityName} {CityName, 23}\n";
        }
    }
}
