using System;

namespace WhichHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementera följande flödesschema med metoder och användarinmatning
            // https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large

            // Informs the user about what the program does and how many questions there are
            Console.WriteLine("Detta program tar reda på vad det är för högtid som firas med hjälp av upp till 11 metoder");
            // Calls the Sill method
            Sill();
            // Thanks the user for using the program after they have reached a concluding answer
            Console.WriteLine("Tack för att du använde programmet");
        }
        // Method for reading user input 
        // Returns a bool value because every question only has two possible paths
        static bool Inmatning()
        {
            // Declaring a bool variable for the do-while loop 
            bool exitloop;
            // Declaring a string variable in order to use it outside of the do-while loop
            string lowerTrimUserInput;
            // Do-while loop to read user input and repeat the process if necessary
            do
            {
                // Declares a string variable and assigns it the user input
                string userInput = Console.ReadLine();
                // Converts the user input into a lowercase string with no whitespace before or after the string
                lowerTrimUserInput = userInput.Trim().ToLower();

                // Checks if the converted user input is = "y" and break out of the loop if it is
                if (lowerTrimUserInput == "y")
                    break;
                // Checks if the converted user input is = "n" and break out of the loop if it is
                else if (lowerTrimUserInput == "n")
                    break;
                // Informs the user that what they inputted isn't valid and asks them to try again
                Console.WriteLine("Invalid user input. Try again");
                // Turns the exitloop variable true so that it iterates through again
                exitloop = true;
            }
            while (exitloop == true); // Condition for continuing the loop

            // Checks if the answer is 'y' and returns true if it is
            if (lowerTrimUserInput == "y")
                return true;
            // Checks if the answer is 'n' and returns false if it is
            else if (lowerTrimUserInput == "n")
                return false;
            // Catches code that might not be y/n, it shouldn't ever happen though. Returns false
            else
            {
                Console.WriteLine("This wasn't supposed to happen");
                return false;
            }
        }
        // Method for asking the sill question
        static void Sill()
        {
            // Asks the user if you eat herring
            Console.WriteLine("Äter man sill? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool sillAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (sillAnswer == true)
            {
                // If yes call the fika method
                Fika(); 
            }
            else
            {
                // If no call the must method
                Must();
            }
        }
        // Method for asking the must question
        static void Must()
        {
            // Asks the user if you drink must
            Console.WriteLine("Dricker man must? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool mustAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (mustAnswer == true)
            {
                // If yes call the TV method
                TV();
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är midsommar!");
            }
        }
        // Method for asking the TV question
        static void TV()
        {
            // Asks the user if you watch TV at 3 pm
            Console.WriteLine("Kollar man TV kl. 15:00? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool TVAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (TVAnswer == true)
            {
                // If yes type out which holiday it is
                Console.WriteLine("Det är jul!");
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är påsk!");
            }
        }
        // Method for asking the fika question
        static void Fika()
        {
            // Asks the user if fika is important
            Console.WriteLine("Är fika viktigt? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool fikaAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (fikaAnswer == true)
            {
                // Calls the vispgrädde mthod
                Vispgrädde();
            }
            else
            {
                // Calls the USA method
                USA();
            }
        }
        // Method for asking the vispgrädde question
        static void Vispgrädde()
        {
            // Asks the user if you eat vispgrädde
            Console.WriteLine("Vispgrädde? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool vispgräddeAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (vispgräddeAnswer == true)
            {
                // Calls the sylt method
                Sylt();
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är kanelbullens dag!");
            }
        }
        // Method for asking the sylt question
        static void Sylt()
        {
            // Asks the user if you eat sylt
            Console.WriteLine("Sylt till? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool syltAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (syltAnswer == true)
            {
                // If yes type out which holiday it is
                Console.WriteLine("Det är våffeldagen!");
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är fettisdagen!");
            }
        }
        // Method for asking the USA question
        static void USA()
        {
            // Asks the user if the holiday is from the USA
            Console.WriteLine("Importerat från USA av köpmän (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool USAAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (USAAnswer == true)
            {
                Köper();
            }
            else
            {
                Bakfull();
            }
        }
        // Method for asking the bakfull question
        static void Bakfull()
        {
            // Asks the user if you are bakfull
            Console.WriteLine("Är man bakfull? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool bakfullAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (bakfullAnswer == true)
            {
                // Calls the Ivanhoe method
                Ivanhoe();
            }
            else
            {
                // Calls the orsak method
                Orsak();
            }
        }
        // Method for asking the orsak question
        static void Orsak()
        {
            // Asks the user if people know the reason for celebrating
            Console.WriteLine("Vet folk orsaken till firandet? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool orsakAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (orsakAnswer == true)
            {
                // If yes type out which holiday it is
                Console.WriteLine("Det är kristi himmelsfärd!");
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är nationaldagen!");
            }
        }
        // Method for asking the Ivanhoe question
        static void Ivanhoe()
        {
            // Asks the user if you watch Ivanhoe
            Console.WriteLine("Kollar man på Ivanhoe? (y/n)");
            // Creates a bool variable to store the return value from the inmatning method
            bool ivanhoeAnswer = Inmatning();
            // If statement that checks if the answer was yes or no
            if (ivanhoeAnswer == true)
            {
                // If yes type out which holiday it is
                Console.WriteLine("Det är nyårsdagen!");
            }
            else
            {
                // If no type out which holiday it is
                Console.WriteLine("Det är första maj!");
            }
        }
        // Method for asking the köper question
        static void Köper()
        {
            // Asks the user what you buy. Rosor or pumpor
            Console.WriteLine("Vad köper man? (y = rosor/n = pumpor)");
            // Creates a bool variable to store the return value from the inmatning method
            bool köperAnswer = Inmatning();
            // If statement that checks if the answer was yes(rosor) or no(pumpor)
            if (köperAnswer == true)
            {
                // If yes(rosor) type out which holiday it is
                Console.WriteLine("Det är alla hjärtans dag!");
            }
            else
            {
                // If no(pumpor) type out which holiday it is
                Console.WriteLine("Det är halloween!");
            }
        }
    }
}
