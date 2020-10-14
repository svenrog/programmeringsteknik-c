using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace HansJohnnysButikApp
{
    public class Albums : Media
    {
        public int AmountSongs { get; set; }
        //public bool IsFeaturing { get; set; }
        
        const string _separator = ";";
        //public static List<Albums> AlbumList = new List<Albums>();
        //Songs songs = new Songs();

        public Albums(string fromAlbumCsv)
        {
            Random randomizer = new Random();
            string[] columns = fromAlbumCsv.Split(_separator);

            Id = Convert.ToInt32(columns[0]);
            Name = columns[1];
            Producer = columns[2];
            UserGrade = Convert.ToDouble(columns[3]);
            ReleaseDate = Convert.ToDateTime(columns[4]);
            Length = Convert.ToDateTime(columns[5]);
            Price = randomizer.Next(49, 259);
        }
        public static void PrintAlbums(IEnumerable<Albums> music)
        {
            IEnumerable<Albums> musicSortedByUserGrade = music.OrderByDescending(p => p.UserGrade)
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
        public static void AlbumsWithSongs(IEnumerable<Albums> albums, IEnumerable<Songs> songs)
        {
            Dictionary<int, string> dictionaryAlbumsAndSongs = new Dictionary<int, string>();

            //var songsFromSonglist = Songs.();
            foreach (var album in albums)
            {
                //Console.WriteLine($"{songs.Name,37} {songs.Producer,30} {songs.Length,10:mm:ss}");
            }
        }
        //{

        //    dictionaryAlbums = Shop.AlbumList.ToDictionary(a => a.Name);
        //    dictionarySongs = Shop.SongList.ToDictionary(p => p.Name);

        //    foreach (KeyValuePair<string, Songs> kvp in dictionarySongs)
        //    {
        //        Console.WriteLine($"Key: {kvp.Key}");
        //        Songs p = kvp.Value;
        //        Console.WriteLine($"Id: {p.Id} Namn: {p.Name} Feat.: {p.Producer} Length: {p.Length}");
        //    }

        //    //Dictionary<Shop.MusicList, Shop.SongList> dictionaryWithIntegerKeys = new Dictionary<Shop.MusicList, Shop.SongList>();

        //    //    /* ToDo: 1. Skapa en relation mellan sång och artist.
        //    //     *       2. Skapa en metod som tar inparameter Artist och returnerar alla sånger med den artisten.
        //    //     *       3. Skapa en metod som tar inparameter Artist och låtlängd och returnerar sånger större än eller mindre
        //    //     *          än ett visst värde typ 2 min.
        //    //     *      Tips: sorteringsalgoritmen sist. När allt funkar i varje steg så petar jag in sortering.
        //    //     */
    }
    }
}
