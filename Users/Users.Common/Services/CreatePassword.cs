using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Common.Services
{
    public class CreatePassword
    {
        public static object CreatePasswords()
        {
            Console.WriteLine("Password");
            Console.WriteLine();

            Console.Write("How many characters do you want your password to be? (7 minimum) ");
            uint passwordLength;
            do
            {
                var characterInput = Console.ReadLine();
                passwordLength = uint.Parse(characterInput);
            } while (passwordLength < 7);

            Console.Write("How many uppercase letters? (3 minimum) ");
            uint upperCaseCount;
            do
            {
                var upperCaseInput = Console.ReadLine();
                upperCaseCount = uint.Parse(upperCaseInput);
            } while (upperCaseCount < 3);

            Console.Write("How many numbers? (2 minimum) ");
            uint numberCount;
            do
            {
                var numberInput = Console.ReadLine();
                numberCount = uint.Parse(numberInput);
            } while (numberCount < 2);

            Console.Write("How many special characters? (2 minimum) ");
            uint specialCount;
            do
            {
                var specialInput = Console.ReadLine();
                specialCount = uint.Parse(specialInput);
            } while (specialCount < 2);

            var passwordGenerator = new PasswordService();
            passwordGenerator.ValidatePassword(passwordLength, upperCaseCount, numberCount, specialCount);
            var password = passwordGenerator.GeneratePassword(passwordLength, upperCaseCount, numberCount, specialCount);

            return password;
        }
    }
}
