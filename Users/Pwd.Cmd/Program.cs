using System;
using Users.Common.Services;

namespace Pwd.Cmd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Skriv ett program som genererar ett lösenord baserat på följande parametrar:
            // 1. Längd (positivt heltal)
            // 2. Antal stora bokstäver.
            // 3. Antal siffror.
            // 4. Antal specialtecken.

            //PasswordService passwordService = new PasswordService();
            //string passowrd = passwordService.GeneratePassword(10, 2, 3, 1);
            //IServiceResponse serviceResponse = passwordService.ValidatePassword(passowrd, 10, 2, 3, 1);

            //if (serviceResponse.Success)
            //    Console.WriteLine(serviceResponse.Message);
            //else
            //    throw serviceResponse.Exception;

            Console.WriteLine("Password Generator");
            Console.WriteLine("___________________");
            Console.WriteLine();

            Console.Write("How many characters do you want your password to be? ");
            var characterInput = Console.ReadLine();
            var passwordLenght = uint.Parse(characterInput);

            Console.Write("How many uppercases? ");
            var uppercaseInput = Console.ReadLine();
            var uppercaseCount = uint.Parse(uppercaseInput);

            Console.Write("How many numbers? ");
            var numbersInput = Console.ReadLine();
            var numberCount = uint.Parse(numbersInput);

            Console.Write("How many special characters? ");
            var specialInput = Console.ReadLine();
            var specialCount = uint.Parse(specialInput);

            var passwordService = new PasswordService();
            var passowrd = passwordService.GeneratePassword(passwordLenght, uppercaseCount, numberCount, specialCount);

            Console.WriteLine($"Your password is {passowrd}");
        }
    }
}