using System;
using System.Collections.Generic;
using System.Text;

namespace HansJohnnysButikApp
{
    public class Menu
    {
        public void run()
        {
            Console.Title = "Hans-Johnny's musik och film.";

            MediaReader mr = new MediaReader();

            Shop.BillingAdress = "Blåbärsgatan 46 C";
            Shop.VisitingAdress = "Murkelgatan 23";
            Shop.ZipCodeBilling = 80251;
            Shop.ZipCodeing = 80256;
            Shop.CityName = "Gävle";

            Console.WriteLine(Shop.WelcomeToTheShop());
            Console.WriteLine(Shop.PrintBothAdresses());

            PrintMenu();
        }
        public static void PrintMenu()
        {
            bool isRunning = true;
            int menuChoise = 0;

            do
            {
                Console.WriteLine("\nGör ett val i menyn\n" +
                                    "[1] Visa filmer.\n" +
                                    "[2] Visa musik album.\n" +
                                    "[3] Visa alla låtar.\n" +
                                    //"[4] Visa album med låtar.\n" +
                                    "[5] Avsluta.");
                try
                {
                    menuChoise = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Oj! Du skrev nog fel! Försök igen.\n{ex}");
                }
                Console.Clear();
                {
                    switch (menuChoise)
                    {
                        case 1:
                            Movies.PrintMovies(Shop.MovieList);
                            menuChoise = 0;
                            break;
                        case 2:
                            Albums.PrintAlbums(Shop.AlbumList);
                            menuChoise = 0;
                            break;
                        case 3:
                            Songs.PrintSongs(Shop.SongList);
                            menuChoise = 0;
                            break;
                        //case 4:
                        //    Songs.AlbumsWithSongs(Songs.SongList);
                        //    menuChoise = 0;
                        //    break;
                        case 5:
                            Console.WriteLine("\nDu lämnar nu Hans-Johnny's butik. Välkommen åter!");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("\nOj! Du skrev nog fel. Försök igen!");
                            break;
                    }
                }
                Console.WriteLine(Shop.PrintVisitingAdress());
            } while (isRunning);
        }
    }
}
