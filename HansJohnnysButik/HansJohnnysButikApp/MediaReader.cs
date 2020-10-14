using System;
using System.IO;

namespace HansJohnnysButikApp
{
    public class MediaReader
    {
        public string _movie;
        public string _music;
        public string _song;
        //public string myDummyString = ReadFromMoviesCsv("Dummy.txt");
        public MediaReader()
        {
            _movie = ReadFromMoviesCsv("Movies.csv");
            _music = ReadFromMusicCsv("Albums.csv");
            _song = ReadFromSongsCsv("Songs.csv");
        }
        public static string ReadFromMoviesCsv(string csvFileReadMovies)
        {
            bool isNotNull = true;
            string myMovieCsvDataSet = "";
            try
            {
                using (FileStream fileStream = File.Open(csvFileReadMovies, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            myMovieCsvDataSet = fileStreamReader.ReadLine();
                            if (myMovieCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.MovieList.Add(new Movies(myMovieCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return myMovieCsvDataSet;
        }
        public static string ReadFromMusicCsv(string csvFileReadMusic)
        {
            bool isNotNull = true;
            string myMusicCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileReadMusic, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            myMusicCsvDataSet = fileStreamReader.ReadLine();
                            if (myMusicCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.AlbumList.Add(new Albums(myMusicCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return myMusicCsvDataSet;
        }
        public static string ReadFromSongsCsv(string csvFileReadSongs)
        {
            bool isNotNull = true;
            string mySongCsvDataSet = "";

            try
            {
                using (FileStream fileStream = File.Open(csvFileReadSongs, FileMode.Open))
                {
                    using (StreamReader fileStreamReader = new StreamReader(fileStream))

                        while (isNotNull)
                        {
                            mySongCsvDataSet = fileStreamReader.ReadLine();
                            if (mySongCsvDataSet == null)
                            {
                                isNotNull = false;
                            }
                            else
                            {
                                Shop.SongList.Add(new Songs(mySongCsvDataSet));
                            }
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found. Error!");
            }
            return mySongCsvDataSet;
        }
    }
}
