using System;

namespace FelhanteringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int buildError = "stringVaue"; (angett fel värdetyp, här int och string)

            //för att undvika att fel avslutar körningen måste man hantera evetuela körtidsfel med try catch
            
            try
            {
                string word = "12a";
                int integer = int.Parse(word);
            }
            catch (Exception ex)
            
                // denna del är till för att hantera felet, visa fel för användaten eller att skriva till logg.
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                //körs alltid, är till för att städa upp körningen
                //körs öven om try-satsen innehåller return;
            }
        }
    }
}
