using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;

namespace HansJohnnysButikApp
{
    public class Movies : Media
    {
        const string _separator = ";";
        public Movies(string csv)
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
        public static void PrintMovies(IEnumerable<Movies> movies)
        {
            IEnumerable<Movies> moviesSortedByReleaseDate = movies.OrderByDescending(p => p.ReleaseDate)
                                           .ThenBy(p => p.Producer)
                                           .ThenBy(p => p.Name)
                                           .ToList();
            
            foreach (var movie in moviesSortedByReleaseDate)
            {
                Console.WriteLine($"Film: {movie.Name}\n     " +
                    $"Regisör: {movie.Producer}\n     " +
                    $"Release datum: {movie.ReleaseDate:yyyy-MM-dd}\n     " +
                    $"Rating:{movie.UserGrade}\n     " +
                    $"Längd:{movie.Length:hh:mm}\n  " +
                    $"   Pris: {movie.Price}:-\n");
            }
        }
    }
}
