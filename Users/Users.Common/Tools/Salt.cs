using System;
using System.Collections.Generic;
using System.Text;
using Users.Common.Services;

namespace Users.Common.Tools
{
    public static class Salt
    {
        public static string Generate()
        {
            PasswordService generate = new PasswordService();
            Random roll = new Random();
            string salt = generate.GeneratePassword(60, (uint)roll.Next(0, 19), (uint)roll.Next(0, 19), (uint)roll.Next(0, 19));
            salt = salt.Replace(";", "|");
            return salt;
        }
    }
}
