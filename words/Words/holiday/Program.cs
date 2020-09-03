namespace WhichHolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementera följande flödesschema med metoder och användarinmatning
            // https://pbs.twimg.com/media/EQup9bwXUAEK5a_?format=jpg&name=large

            Console.WriteLine("Äter man sill? (y/n)");
            int sillAnswer = Inmatning();

        }
        static int Inmatning()
        {
            bool exitloop = true;
            do
            {
                exitloop = true;
                string userInput = Console.ReadLine();
                string lowerTrimUserInput = userInput.Trim.ToLower();
                if (lowerTrimUserInput == "y")
                    return 0;
                else if (lowerTrimUserInput == "n")
                    return 1;
                else
                {
                    Console.WriteLine("Invalid user input. Try again");
                    exitloop = false;
                }
            }
            while (true)
        }
        static string Fråga(int svar)
        {
            if (svar == 0)

        }
    }
}
