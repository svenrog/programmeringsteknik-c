using System;
using System.IO;

namespace HansJohnnysButikApp
{
    public class MediaReader
    {
        public string myMovieString;
        public string myMusicString;
        public string mySongString;
        //public string myDummyString = ReadFromMoviesCsv("Dummy.txt");
        public MediaReader()
        {
            myMovieString = ReadFromMoviesCsv("Movies.csv");
            myMusicString = ReadFromMusicCsv("Albums.csv");
            mySongString = ReadFromSongsCsv("Songs.csv");
        }
        public static string ReadFromMoviesCsv(string csvFileName)
        {
            bool isNotNull = true;
            string myCsvDataSet = "";
            try
            {
                using (FileStream fileStream = File.Open(csvFileName, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            myCsvDataSet = fileStreamReader.ReadLine();
                            if (myCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.MovieList.Add(new Movies(myCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return myCsvDataSet;
        }
        public static string ReadFromMusicCsv(string csvFileName)
        {
            bool isNotNull = true;
            string myCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileName, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            myCsvDataSet = fileStreamReader.ReadLine();
                            if (myCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.MusicList.Add(new Music(myCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return myCsvDataSet;
        }
        public static string ReadFromSongsCsv(string csvFileName)
        {
            bool isNotNull = true;
            string myCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileName, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            myCsvDataSet = fileStreamReader.ReadLine();
                            if (myCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.SongList.Add(new Songs(myCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return myCsvDataSet;
        }
    }
}
