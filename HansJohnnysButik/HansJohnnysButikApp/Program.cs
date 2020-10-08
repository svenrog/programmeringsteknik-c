using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HansJohnnysButikApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Hans-Johnny's musik och film.";
            var mr = new MediaReader();

            Movies.PrintMovies(Shop.MovieList);
            Music.PrintMusic(Shop.MusicList);
            Songs.PrintSongs(Shop.SongList);

            Shop.BillingAdress = "Blåbärsgatan 46 C";
            Shop.VisitingAdress = "Murkelgatan 23";
            Shop.ZipCodeBilling = 80251;
            Shop.ZipCodeing = 80256;
            Shop.CityName = "Gävle";

            Console.WriteLine(Shop.PrintBothAdresses());
            
            //ViewMenu(shop);

            Console.WriteLine("\nTryck på valfri tangent för att avsluta programmet.");
            Console.ReadKey(true);
        }
        //public static void ViewMenu(Shop shop)
        //{
        //    bool isRunning = true;
            
        //    do
        //    {                
        //        Console.WriteLine("\nGör ett val i menyn\n" +
        //                            "[1] Visa filmer.\n" +
        //                            "[2] Visa musik album.\n" +
        //                            "[3] Visa album med låtar.\n" +
        //                            "[4] Visa alla filmer och alla album.\n" +
        //                            "[5] Avsluta.");
        //        try
        //        {
        //            menuChoise = Convert.ToInt32(Console.ReadLine());
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Oj! Du skrev nog fel! Försök igen.\n{ex}");                    
        //        }
        //        Console.Clear();
        //        {
        //            switch (menuChoise)
        //            {
        //                case 1:
        //                    ViewMedia();
        //                    menuChoise = 0;
        //                    break;
        //                case 2:
        //                    ViewMedia();
        //                    menuChoise = 0;
        //                    break;
        //                case 3:
        //                    ViewMedia();
        //                    menuChoise = 0;
        //                    break;
        //                case 4:
        //                    ViewMedia();
        //                    menuChoise = 0;
        //                        break;
        //                case 5:
        //                    Console.WriteLine("Du lämnar nu Hans-Johnny's butik. Välkommen åter!");
        //                    isRunning = false;
        //                    break;
        //                default:
        //                    Console.WriteLine("Oj! Du skrev nog fel. Försök igen!");
        //                    break;
        //            }
        //        }
        //        Console.WriteLine(shop.PrintVisitingAdress());
        //    } while (isRunning);
        //}        
    }
}
