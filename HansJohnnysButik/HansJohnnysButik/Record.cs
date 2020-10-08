using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButik
{
    class Record : Media
    {
        //        Namn
        //Regissör
        //Snittbetyg från användare(0-10)
        //Releasedatum, Speltid(i minuter och timmar)
        //Pris
        private static Record[] recordsInStore;


        int trackAmount;
        public Record(string artist, string title, AlbumInfo info, byte userReview, price price) : base(title, userReview, price)
        {
            AlbumInformation = info;
        }
        static Record()
        {
            RecordsInStock = new[]
            {

                //Artist: Vikingarna
                //Album: Kramgoa favoriter 54
                //Utgivningsår: 1759
                //Antal låtar: 11
                //Total Speltid: 1 h 20 minuter
                //Format: 

                //Pris: 99.99 kr

                new Record("Vikingarna", "Kramgoa favoriter 5", AlbumInfo.GetAlbumInfo(1989, 11, 1,2, "Kasset"), 10, new price(99.50m))
                //new Record("AC/DC", "Back in Black", 11, new TimeSpan(1, 30, 0), "Kasset", 6, DateTime.Now, new price(99.50m)),
                //new Record("Styx","River Hades", 8, new TimeSpan(1, 49, 0), "Kasset", 6, new DateTime(1985), new price(79.99m, "USD")),
                //new Record("AC/DC" , "Back in Black", 11, new TimeSpan(1, 30, 0), "Kasset", 6, DateTime.Now, new price(99.50m)),
                //new Record("Styx", "River Hades", 8, new TimeSpan(1, 49, 0), "Kasset", 6, new DateTime(1985), new price(79.99m)),
                //new Record("Vikingarna", " Kramgoa favoriter 5", 12, new TimeSpan(0, 57, 0), "LP",  10, DateTime.Now, new price(99.50m))


            };
        }
        /*
         NamnArtistSnittbetyg från användare (0-10)ReleasedatumSpeltid (i minuter och timmar)Antal låtarPris
        */

        public string Artist { get; set; }
        public static Record[] RecordsInStock
        {
            get { return recordsInStore; }
            set { recordsInStore = value; }
        }
        public AlbumInfo AlbumInformation { get; set; }
        //public class AlbumInfo : Record
        //{
        //    //public AlbumInfo(DateTime releaseYear, int songAmount, TimeSpan playTime, string mediaType)  //StringBuilder trackInfo
        //    //{
        //    //    ReleaseYear = releaseYear;
        //    //    SongAmount = songAmount;
        //    //    Duration = playTime;
        //    //    Format = mediaType;
        //    //}

        //    public int SongAmount { get; set; }
        //    //public StringBuilder TrackInfo { get; set; }

        //}
        //public static AlbumInfo GetAlbumInfo(byte year, byte songAmount, byte albumHour, byte hour, byte minutes, string format)
        //{
        //    //AlbumInfo setAlbumInfo =
        //    //    new AlbumInfo(new DateTime(year), songAmount, new TimeSpan(hour, minutes, 0), format);

        //    return setAlbumInfo;
        //}
        //static void GetTrackInfoFromFile()
        //{

        //}
    }


}
