using System;
using Users.Common.Models;

namespace Users.Common.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly Random roll = new Random();

        public string GeneratePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            if (capitalLetters + numbers + specialChars > length)
                throw new ArgumentOutOfRangeException("Password length is less than the sum of requested individual parts.");
            var buffer = new char[length];
            for (var i = 0; i < buffer.Length; i++)
            {
                char currentChar;
                if (i < capitalLetters)
                {
                    currentChar = GetRandomCharacter(Constants.Passwords.Letters);
                    currentChar = char.ToUpper(currentChar);
                }
                else if (i < capitalLetters + numbers)
                    currentChar = GetRandomCharacter(Constants.Passwords.Numbers);
                else if (i < capitalLetters + numbers + specialChars)
                    currentChar = GetRandomCharacter(Constants.Passwords.Special);
                else
                    currentChar = GetRandomCharacter(Constants.Passwords.Letters);


                buffer[i] = currentChar;
            }
            return PasswordShuffler(buffer, length);
        }

        private string PasswordShuffler(char[] buffer, uint length)
        {
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

        public IServiceResponse ValidatePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            throw new NotImplementedException();
        }

        private char GetRandomCharacter(string input)
        {
            var position = roll.Next(0, input.Length);
            return input[position];
        }
    }
}
