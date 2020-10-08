using System;

namespace ConvertTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //My solution on converting seconds to h/m/s
            Console.WriteLine("Let's convert seconds to hours, minutes & seconds! ");
            Console.Write("Enter a number in seconds and let's convert: ");

            int minCounter = 0;
            int secCounter = 0;

            var time = Console.ReadLine();
            int.TryParse(time, out int counter);

            if (counter >= 0 && counter < 60)
            {
                Console.WriteLine($"{counter} Seconds!");
            }

            else if (counter >= 60 && counter < 3600)
            {

                minCounter = counter / 60;
                secCounter = counter % 60;

                Console.WriteLine($"{minCounter} Minutes & {secCounter} Seconds!");

            }

            else if (counter >= 3600)
            {
                int hourCounter = counter / 3600;
                counter %= 3600;

                if (counter >= 0 && counter < 3600)
                {

                    minCounter = counter / 60;
                    secCounter = counter % 60;


                }
                Console.WriteLine($"{hourCounter} Hours, {minCounter} Minutes & {secCounter} Seconds!");

            }

            else
            {
                Console.WriteLine("Alfons..");
            }

            Console.ReadKey();
        }
    }
}
