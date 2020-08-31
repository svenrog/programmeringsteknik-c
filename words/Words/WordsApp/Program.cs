using System;
using System.Linq;
using System.Xml.Schema;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en konsolapp som tar emot en skriven text
            //Vi vill ha ut:
            //Antalet ord
            //Antalet vokaler
            //Vilket ord är längst

            //Word count
            //Vowel count
            //Longest word

            Console.WriteLine("Please enter a sentence or more.");
            string input = " " + Console.ReadLine();            //Då jag räknar antalet ord genom whitespaces, och input inte kommer skrivas ut, så lägger jag till
                                                                //ett mellanslag. Det blir dock fel om det inte skrivs in något.

            if (input.Length > 1)                               //Om input är 0 är något fel; om den är 1 så skrevs inget in.
            {


                //Steg ett är att hitta all "whitespace"; mellanslag, för att se hur många olika ord som finns.
                int[] whitespace = new int[input.Length];

                //Loopen körs en gång för varje tecken i input; om den hittar ett mellanslag så får motsvarande plats i integer arrayen 'whitespace'
                // en etta, annars får den en nolla. Så nolla betyder "inte mellanslag".
                for (int i = input.Length; i > 0; i--)
                {
                    if (input.Substring((i - 1), 1) == " ")
                    {
                        whitespace[(i - 1)] = 1;
                    }
                    else
                        whitespace[(i - 1)] = 0;
                }


                /*for (int i = input.Length; i > 0; i--)
                {
                    Console.WriteLine(whitespace[(i - 1)]);
                }*/


                //Nu har vi en lista i en array. Alla ettor är mellanslag/whitespace, medan nollor är andra tecken.
                //Loopens körs lika många gånger som antalet tecken i input.
                //Varje gång den hittar en etta i 'whitespace' arrayen, som motsvarar ett mellanslag i input, så ökar den ordräknaren 'wordcount'
                int wordcount = 0;
                for (int i = input.Length; i > 0; i--)
                {
                    if (whitespace[(i - 1)] == 1)
                    {
                        wordcount++;
                    }
                }

                if (input.Length == 0)                       //Den här borde inte träffas, kvar sen innan jag la till första if-satsen.
                        Console.WriteLine("The word count is zero.");
                else 
                        Console.WriteLine("The word count is " + wordcount);


                char[] vowels = { 'a', 'o', 'i', 'u', 'y', 'å', 'ä', 'ö', 'e' };
                int check = 0;
                int vowelCount = 0;

                /* Kör loopen en gång för varje värde/tecken sparat i 'input'.
                 * I den loopen körs en innre loop hårdkodad med antalet vokaler.
                 * I den innre loopen finns en if-sats som kollar ifall nuvarande tecknet i input (som definerat av yttre loopen) är lika med varje tecken i 'vowels'
                 * Om ja så ökar den vowelCount.
                 * */
                for (int i = input.Length; i > 0; i--)
                {
                    for (int n = 0; n < 9; n++)
                    {
                        check = vowels[n].CompareTo(Convert.ToChar(input.Substring((i - 1), 1)));      //CompareTo ger ett värde som inte är noll om det inte är samma.
                        if (check == 0)
                        {
                            vowelCount++;
                        }
                    }
                }
                Console.WriteLine("The vowel count is: " + vowelCount);


                //genom att räkna hur många nollor i rad som är mest så kan vi se vilket ord som är längst i vår 'whitespace' array.
                //alternativt kan vi leta efter största hålet mellan whitespaces i 'input'
                int charCounter = 0;
                int positionIndex = 0;
                int currentLargest = 0;
                int ticker = whitespace.Length - 1;


                /*Loop med if-sats inom if-sats.
                 * Loopen går igenom lika många gånger som det finns värden i arrayen 'whitespace'.
                 * Första if-satsen börjar kollar sista platsen i 'input', och går bakåt varje loop, för att se om det är ett mellanslag eller inte.
                 * Om ja så ökar den räknaren för antalet tecken i nuvarande ordet.
                 * Andra if-satsen, som bara aktiveras ifall den första hittar ett mellanslag, jämför ifall nya ordet är större än senast sparade ord.
                 * När den hittar ett större ord efter ett mellanslag så sparar den det nya största ordet samt platsen det hittades på
                 * (plus ett då nuvarande 'ticker' pekar på mellanslaget före)
                 * och sen nollar den 'charCounter' så den kan börja räkna ett nytt ord.
                 * Om den inte hittar ett större ord så nollar den bara räknaren och går vidare.
                 * Sen är vi tillbaka utanför den innre if-satsen och nollar räknaren igen.
                 * Utanför if-satserna så minskar loopen räknaren och startar om.*/
                foreach (int i in whitespace)
                {
                    if (whitespace[ticker] == 0)
                    {
                        charCounter++;
                    }
                    else
                    {
                        if (charCounter > currentLargest)
                        {
                            currentLargest = Math.Max(charCounter, currentLargest);
                            charCounter = 0;
                            positionIndex = ticker + 1;
                        }
                        else
                        {
                            charCounter = 0;
                        }
                        charCounter = 0;
                    }
                    ticker--;

                }
                Console.WriteLine("The longest word is \'" + input.Substring(positionIndex, currentLargest) + "\' at " + currentLargest + " characters");

            }
            else Console.WriteLine("You did not follow instructions.");

        }
    }
}
