using System;
using Users.Common.Models;
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

            PasswordService passwordService = new PasswordService();
            string passowrd = passwordService.GeneratePassword(10, 2, 3, 1);
            IServiceResponse serviceResponse = passwordService.ValidatePassword(passowrd, 10, 2, 3, 1);

            if (serviceResponse.Success)
                Console.WriteLine(serviceResponse.Message);
            else
                throw serviceResponse.Exception;

        }
    }
}
