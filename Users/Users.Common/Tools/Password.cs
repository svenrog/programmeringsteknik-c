using System;
using System.Collections.Generic;
using System.Text;
using Users.Common.Services;

namespace Users.Common.Tools
{
    public static class Password
    {
        public static string Generate()
        {
            PasswordService pservice = new PasswordService();
            return pservice.GeneratePassword(15, 4, 4, 3);
        }
    }
}
