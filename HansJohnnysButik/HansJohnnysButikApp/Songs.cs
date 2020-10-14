using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HansJohnnysButikApp
{

    public class Songs : Media
    {
        const string _separator = ";";
        //public static List<Songs> SongList = new List<Songs>();
        public int SongId { get; set; }
        //public string SongName { get; set; }
        //public string Producer { get; set; }
        //public DateTime SongLength { get; set; }
        public Songs(string fromSongsCsv)
        {
            string[] columns = fromSongsCsv.Split(_separator);

            Id = Convert.ToInt32(columns[0]);
            Name = columns[1];
            Producer = columns[2]; // FeaturingArtist
            Length = Convert.ToDateTime(columns[3]);
        }
        public static void PrintSongs(IEnumerable<Songs> songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"{song.SongId,37} {song.Producer,30} {song.Length,10:mm:ss}");
            }
        }
        //public static void AlbumsWithSongs()
        //{ 
        //    foreach (Songs song in SongList)
        //    {
        //        Albums.AlbumList.Find(AlbumList => AlbumList.Id == song.Id).Songs.Add(song);
        //    }
        //}
    }
}
