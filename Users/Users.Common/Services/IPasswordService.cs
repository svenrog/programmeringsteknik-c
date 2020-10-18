using Users.Common.Models;

namespace Users.Common.Services
{
    public interface IPasswordService
    {
        /// <summary>
        /// Generates a password with specified parameters
        /// </summary>
        /// <param name="length">Length of the password in characters</param>
        /// <param name="capitalLetters">Amount of capital letters</param>
        /// <param name="numbers">Amount of numbers</param>
        /// <param name="specialChars">Amount of special characters</param>
        /// <returns>A resulting password as string</returns>
        string GeneratePassword(int length, int capitalLetters = 1, int numbers = 1, int specialChars = 1);

        /// <summary>
        /// Validates a password by specified parameters
        /// </summary>
        /// <param name="length">Length of the password in characters</param>
        /// <param name="capitalLetters">Amount of capital letters</param>
        /// <param name="numbers">Amount of numbers</param>
        /// <param name="specialChars">Amount of special characters</param>
        /// <returns>A response indicating success or failure.</returns>
        IServiceResponse ValidatePassword(int length, int capitalLetters = 1, int numbers = 1, int specialChars = 1);
    }
}
