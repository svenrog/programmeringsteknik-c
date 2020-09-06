using System;

namespace ChessApp
{
    class Program
    {
        //░ och ▓
        static void Main(string[] args)
        {
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("▓▓░░▓▓░░▓▓░░▓▓░░");
            Console.WriteLine("░░▓▓░░▓▓░░▓▓░░▓▓");
            Console.WriteLine("This board was hardcoded.");
            
            string b = "░░";
            string w = "▓▓";

            string evenLine = "";
            string oddLine = "";

            /* Så, först så vill jag ha en loop som skapar två strings, en för rader med jämnt värde, en för rader med ojämnt
             * Loopen är 8 lång då det är bredden på ett shackbräde
             * Då jag vill ha att varannan blir vit och varannan blir svart så har jag en enkel if-sats som kollar om nuvarande loopvärde är jämnt
             * Så varannan loop ger jag de två raderna korrekt färgad ruta.
             */
            for (int n = 0; n < 8; n++)
            {
                if (n % 2 == 0) {
                        //Console.Write(w); 
                    oddLine = String.Concat(oddLine, w);
                    evenLine = String.Concat(evenLine, b);
                }
                    
                else {
                   //Console.Write(b); 
                   oddLine = String.Concat(oddLine, b);
                    evenLine = String.Concat(evenLine, w);
                }
            }
            //Vår andra loop är mycket lättare. Skriv ut de två raderna fyra gånger per, så att vi får 8 rader totalt och därmed ett fyrkantigt shackbräde.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(oddLine);
                Console.WriteLine(evenLine);
            }
            
            Console.WriteLine("This board was generated through looping if statements.");
            //Om jag definerade ett värde utanför looparna som sen användes för att definera deras längd, t.ex. genom user-input, så skulle man kunna
            //skapa ett "shackbräde" av vilken storlek som helst...
            //Så länge som det är ett jämnt värde.

            Console.WriteLine("Please enter an integer. Anything else will probably break things. (It will have dimensions twice as big as the number you enter.)");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string oddLine2 = "";
            string evenLine2 = "";

            for (int n = 0; n < (userInput * 2); n++)
            {
                if (n % 2 == 0)
                {
                    //Console.Write(w); 
                    oddLine2 = String.Concat(oddLine2, w);
                    evenLine2 = String.Concat(evenLine2, b);
                }

                else
                {
                    //Console.Write(b); 
                    oddLine2 = String.Concat(oddLine2, b);
                    evenLine2 = String.Concat(evenLine2, w);
                }
            }


            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(oddLine2);
                Console.WriteLine(evenLine2);
            }

            Console.WriteLine("This board was generated through looping if statements and user input.");
        }
    }
}
