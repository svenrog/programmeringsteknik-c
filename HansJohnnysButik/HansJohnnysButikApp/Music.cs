using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HansJohnnysButikApp
{
    public class Music : Media
    {
        public int AmountSongs { get; set; }
        public bool IsFeaturing { get; set; }

        const string _separator = ";";

        public Music(string csv)
        {
            Random randomizer = new Random();
            string[] columns = csv.Split(_separator);

            Name = columns[1];
            Producer = columns[2];
            UserGrade = Convert.ToDouble(columns[3]);
            ReleaseDate = Convert.ToDateTime(columns[4]);
            Length = Convert.ToDateTime(columns[5]);
            Price = randomizer.Next(49, 259);
        }
        public static void PrintMusic(IEnumerable<Music> music)
        {
            IEnumerable<Music> musicSortedByUserGrade = music.OrderByDescending(p => p.UserGrade)
                                                    .ThenBy(p => p.Producer)
                                                    .ThenBy(p => p.Name)
                                                    .ToList();
            foreach (var album in musicSortedByUserGrade)
            {
                Console.WriteLine($"Album: {album.Name}: " +
                    $"{album.Producer}\n      " +
                    $"Rating: {album.UserGrade}\n      " +
                    $"Release datum: {album.ReleaseDate:yyyy-MM-dd} \n      " +
                    $"Speltid: {album.Length:mm:ss} \n      " +
                    $"Antal låtar:{album.AmountSongs} \n      " +
                    $"Pris: {album.Price}:-\n");
            }
        }
        //public static void ConnectSongsWithAlbums()
        //{
        //Dictionary<Shop.MusicList, Shop.SongList> dictionaryWithIntegerKeys = new Dictionary<Shop.MusicList, Shop.SongList>();

        //    /* ToDo: 1. Skapa en relation mellan sång och artist.
        //     *       2. Skapa en metod som tar inparameter Artist och returnerar alla sånger med den artisten.
        //     *       3. Skapa en metod som tar inparameter Artist och låtlängd och returnerar sånger större än eller mindre
        //     *          än ett visst värde typ 2 min.
        //     *      Tips: sorteringsalgoritmen sist. När allt funkar i varje steg så petar jag in sortering.
        //     */
        //}
    }
}
