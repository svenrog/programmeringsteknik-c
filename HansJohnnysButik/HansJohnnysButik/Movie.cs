using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButik
{
    class Movies : Media
    {
        /*Namn
        Regissör
        Snittbetyg från användare (0-10)
        Releasedatum, Speltid (i minuter och timmar)
        Pris*/
        public Movies(string title, string director, TimeSpan duration, string format, byte userReview, DateTime releaseYear, price price) : base(title, duration, format, userReview, releaseYear, price)
        {
            Director = director;
        }

        static Movies ()
        {
            MoviesInStock = new List<Movies>
            { 
                //oviesInStock.Add("Reine och Mimmie i fjällen", "Mats Helgesson", )
                
            
            
            };

        }
        public string Director { get; set; }

        private static List<Movies> MoviesInStock { get; set; }
    }
}
