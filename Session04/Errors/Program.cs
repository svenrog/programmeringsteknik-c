using System;

namespace Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            //int buildError = "stringValue";

            //För att undvika att fel avslutar körning måste man hantera eventuella körtidsfel med try catch.
            try
            {
                string word = "12a";
                int integer = int.Parse(word,);
            }
            catch (Exception ex)
            {
                //denna del är till för att hantera felet, visa fel för användaren eller att skriva till logg
                Console.WriteLine(ex.Message);
                //går att använda throw; för att kasta om felet
            }
            finally
            {
                //körs alltid, är till för att städa upp körningen. 
                //körs även om try-satsen innehåller return;
            }
        }
    }
}
