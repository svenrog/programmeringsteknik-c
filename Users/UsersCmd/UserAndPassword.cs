using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Cmd
{
    class UserAndPassword
    {
        public bool Check(string hashFromInput, string hashFromDatabase)
        {
            return (hashFromDatabase == hashFromInput);
        }
    }
}
