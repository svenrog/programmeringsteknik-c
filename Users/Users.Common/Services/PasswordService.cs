using System;
using System.Dynamic;
using System.Text;
using Users.Common.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.IO.Pipes;
using Users.Common.Services;
using Users.Common;

namespace Users.Common.Services
{
    public class PasswordService : IPasswordService
    {
        private const string _letters = "abcdefghijklmnopqrstuvwxyz";
        private const string _numbers = "1234567890";
        private const string _special = Constants.Passowrds.SpecialCharecters;

        public string GeneratePassword(uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            //if ((capitalLetters + numbers + specialChars) > length)
            //    throw new ArgumentOutOfRangeException("Capital letters, number and special charterers exceed length of password");

            //var buffer = new char[length];
            //for (int i = 0; i < buffer.Length; i++)
            //{
            //    var currentChareckter = GetRandomCharecter(_letters);
            //    if (i < capitalLetters)
            //    {
            //        currentChareckter = char.ToUpper(currentChareckter);
            //    }
            //    else if (i >= length - specialChars) 
            //    {
            //        currentChareckter = GetRandomCharecter(_special);
            //    }
            //    else if (i >= length - numbers - specialChars)
            //    {
            //        currentChareckter = GetRandomCharecter(_numbers);
            //    }
            //    buffer[i] = currentChareckter;
            //}
            //return new string(buffer);

            Random random = new Random();
            StringBuilder password = new StringBuilder();
            if ((capitalLetters + numbers + specialChars) > length)
                throw new ArgumentOutOfRangeException("Capital letters, number and special charterers exceed length of password");
            for (int i = 0; i < length; i++)
            {

                char? charToAppend = null;

                while (charToAppend == null)
                {
                    int charChoise = random.Next(4);
                    switch (charChoise)
                    {
                        case 0:
                            if (capitalLetters > 0)
                            {
                                charToAppend = _letters.ToUpper()[random.Next(_letters.Length)];
                                capitalLetters--;
                                break;
                            }
                            else
                                continue;

                        case 1:
                            if (numbers > 0)
                            {
                                charToAppend = _numbers[random.Next(_numbers.Length)];
                                numbers--;
                                break;
                            }
                            else
                                continue;

                        case 2:
                            if (specialChars > 0)
                            {
                                charToAppend = _special[random.Next(_special.Length)];
                                specialChars--;
                                break;
                            }
                            else
                                continue;

                        case 3:
                            charToAppend = _letters[random.Next(_letters.Length)];
                            break;
                    }
                    password.Append(charToAppend);
                }
            }
            return password.ToString();
        }

        public IServiceResponse ValidatePassword(string password, uint length, uint capitalLetters = 1, uint numbers = 1, uint specialChars = 1)
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            uint capitalLettersCount = 0;
            uint numbersCount = 0;
            uint specialCharsCount = 0;

            foreach (char symbol in password)
            {
                if (_letters.ToUpper().Contains(symbol))
                {
                    capitalLettersCount++;
                    continue;
                }

                if (_numbers.Contains(symbol))
                {
                    numbersCount++;
                    continue;
                }
                if (_special.Contains(symbol))
                {
                    specialCharsCount++;
                    continue;
                }
            }
            if (length == password.Length
                && capitalLetters == capitalLettersCount
                && numbers == numbersCount
                && specialChars == specialCharsCount)
            {
                serviceResponse.Success = true;
                serviceResponse.Message = "Password validation success";
            }
            else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Password validation not successful";
                serviceResponse.Exception = new ArgumentOutOfRangeException(
                    $"Length: {password.Length}\n" +
                    $"Capital letters: {capitalLettersCount}\n" +
                    $"Numbers: {numbersCount}\n" +
                    $"Special characters: {specialCharsCount}");
            }

            return serviceResponse;
        }
        private char GetRandomCharecter(string chareckters)
        {
            var position = new Random().Next(chareckters.Length);
            return chareckters[position];
        }
}
    public class ServiceResponse : IServiceResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}