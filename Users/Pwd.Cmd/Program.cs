using System;
using Users.Common.Services;

namespace Pwd.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program som genererar ett lösenord baserat på följande parametrar:
            // 1. Längd (positivt heltal)
            // 2. Antal stora bokstäver.
            // 3. Antal siffror.
            // 4. Antal specialtecken.
            Console.WriteLine("\n--- Please enter the number of characters you want in your password ---");
            uint length = IntegerInput();

            Console.Write($"Length is {length}.\n \nPlease enter the number of capitalized letters you want.\nKeep in mind that the sum of this and the following two has to be less than or equal to length.");
            uint capitalLetters = IntegerInput();

            Console.Write($"Length is {length}, and there will be {capitalLetters} capitalized letters. \nPlease enter the amount of number-characters you want.");
            uint numberCharacters = IntegerInput();

            Console.Write($"Length is {length}, capitalized letters and numbers together are {capitalLetters + numberCharacters}.\n Please enter a number below {length - (capitalLetters + numberCharacters)} for number of special characters.");
            uint specialCharacters = IntegerInput();

            PasswordService passwordService = new PasswordService();
            string password = passwordService.GeneratePassword(length, capitalLetters, numberCharacters, specialCharacters);
            Console.Write($"Your password is: {password}");
        }

        private static uint IntegerInput()
        {
            uint length;
            try
            {
                length = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Only whole numbers (integers) allowed");
                length = IntegerInput();
            }
            return length;
        }
    }
}
