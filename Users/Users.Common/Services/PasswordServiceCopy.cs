using System;
using Users.Common.Models;

namespace Users.Common.Services
{
    public class PasswordServiceCopy : IPasswordService
    {
        private const string _letters = "abcdefghijklmnopqrstuvwxyz";
        private const string _numbers = "1234567890";
        private const string _special = "$%#@!*?:^&";
        private readonly Random roll = new Random();

        public string GeneratePassword2(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            if (capitalLetters + numbers + specialChars > length)
                throw new ArgumentOutOfRangeException();

            var buffer = new char[length];

            for (var i = 0; i < buffer.Length; i++)
            {
                char currentCharacter;

                if (i < length - numbers - specialChars)
                {
                    currentCharacter = Convert.ToChar(GetRandomCharacter(_letters));

                    if (i < capitalLetters)
                    {
                        currentCharacter = char.ToUpper(currentCharacter);
                    }
                }
                else if (i < length - specialChars)
                {
                    currentCharacter = Convert.ToChar(GetRandomCharacter(_numbers));
                }
                else
                {
                    currentCharacter = Convert.ToChar(GetRandomCharacter(_special));
                }
                buffer[i] = currentCharacter;
            }

            while (length > 1)                                          // This loop shuffles. Cooking the raw password into a tasty steak.
            {
                length--;
                int index = roll.Next(0, (int)(length + 1));
                var value = buffer[index];
                buffer[index] = buffer[length];
                buffer[length] = value;
            }
            string password = "";
            foreach (char c in buffer)
            {
                password += c;
            }

            return password;
        }

        public string GetRandomCharacter(string characters)
        {
            return characters.Substring(roll.Next(0, characters.Length - 1), 1);
        }

            public string GeneratePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            if ((capitalLetters + numbers + specialChars) > length)
                throw new ArgumentException("Sum of character types greater than length");
            
            
            string password = "";
            /* First we take the capital letters, then we take the numbers, then the special chars, then we fill out the remaining with lowercase letters */
            password = PasswordBuilder(password, _letters, capitalLetters);
            password = password.ToUpper();
            password = PasswordBuilder(password, _numbers, numbers);
            password = PasswordBuilder(password, _special, specialChars);
            password = PasswordBuilder(password, _letters, (length - (capitalLetters + numbers + specialChars)));

            char[] shuffledPassword = password.ToCharArray();
            while (length > 1)                                          // This loop shuffles. Cooking the raw password into a tasty steak.
            {
                length--;
                int index = roll.Next(0, (int)(length + 1));
                var value = shuffledPassword[index];
                shuffledPassword[index] = shuffledPassword[length];
                shuffledPassword[length] = value;
            }
            password = "";
            foreach (char c in shuffledPassword)
            {
                password += c;
            }
            return password;

        }

        private string PasswordBuilder(string password, string constantString, uint loopCounter)
        {
            for (int i = 0; i < loopCounter; i++)
            {
                password += constantString[roll.Next(0, constantString.Length)];
            }
            return password;
        }

        public IServiceResponse ValidatePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            throw new NotImplementedException();
        }
    }
}
