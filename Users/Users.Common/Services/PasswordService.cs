using System;
using System.Linq;
using Users.Common.Models;

namespace Users.Common.Services
{
    public class PasswordService : IPasswordService
    {
        private const string _letters = "abcdefghijklmnopqrstuvwxyz";
        private const string _numbers = "1234567890";
        private const string _special = "$%#@!*?;:^&";

        public string GeneratePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            if (capitalLetters + numbers + specialChars > length)
                throw new ArgumentOutOfRangeException("capitalLetters + numbers + specialChars is larger than lenght parameter.");

            var buffer = new char[length];

            for (int i = 0; i < buffer.Length; i++)
            {
                var currentCharacter = GetRandomLetter();

                if (i < capitalLetters)
                {                    
                    currentCharacter = char.ToUpper(currentCharacter);
                }
                else if (i < length - numbers)
                {
                    currentCharacter = GetRandomNumber();
                }
                buffer[i] = currentCharacter;
            }

            return new string(buffer);  
        }

        public IServiceResponse ValidatePassword(string password, uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {           
            throw new NotImplementedException();
        }

        private char GetRandomLetter()
        {
            var position = new Random().Next(0, _letters.Length);
            return _letters[position];
        }

        private char GetRandomNumber()
        {
            var position = new Random().Next(0, _numbers.Length);
            return _numbers[position];
        }
    }
}

















//var buffer = new Char[length];

//for (int i = 0; i < buffer.Length; i++)
//{
//    char currentCharacter = GetRandomChar(_letters);
//    if (i < length - numbers - specialChars)
//    {
//        if (i < capitalLetters)
//        {
//            currentCharacter = char.ToUpper(currentCharacter);
//        }
//    }
//    else if (i < length - specialChars)
//    {
//        currentCharacter = GetRandomChar(_numbers);
//    }
//    else
//    {
//        currentCharacter = GetRandomChar(_special);
//    }
//    buffer[i] = currentCharacter;
//}

//return new string(buffer);