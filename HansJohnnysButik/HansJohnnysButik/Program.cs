using System;
using System.Globalization;
using System.Security.Principal;

namespace HansJohnnysButik
{
    //Hans-Johnny har precis startat en butik på nätet där han säljer film och musik till en smalare publik.
    // Butiken har två adresser, en för fakturering och en besöksadress.
    // Butikens utbud består av 25 unika filmer och unika 25 musikalbum.
    /// <summary>
    /// 
    /// </summary>

    
    class Program
    {


        static void Main(string[] args)
        {
            //decimal price = 99.50m;
            //Console.WriteLine(price.ToString("C2", CultureInfo.CurrentCulture));

            Console.WriteLine(UserRating.voidStar + UserRating.saturatedStar);
            Console.ReadKey();
            //for (int i = 0; i < Record.RecordsInStock.Length; i++)
            //{
            //    Console.WriteLine(Record.RecordsInStock[i].Title);
            //    Console.WriteLine(Record.RecordsInStock[i].ReleaseYear);
            //    Console.WriteLine(Record.RecordsInStock[i].Duration);
            //    Console.WriteLine(Record.RecordsInStock[i].Price.displayCost);
            //    Console.WriteLine();
            //}
           



            Console.ReadKey();
        }
    }
}
