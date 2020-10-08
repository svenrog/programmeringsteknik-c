using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButikApp
{

    public class Songs : Media
    {
        const string _separator = ";";

        public Songs(string csv)
        {
            string[] columns = csv.Split(_separator);

            Name = columns[1];
            Producer = columns[2]; // FeaturingArtist
            Length = Convert.ToDateTime(columns[3]);
        }
        public static void PrintSongs(IEnumerable<Songs> songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Name,37} {song.Producer,30} {song.Length,10:mm:ss}");
            }
        }
    }
}
