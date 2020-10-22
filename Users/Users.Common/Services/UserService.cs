using System;
using System.Collections.Generic;
using System.Text;
using Users.Common.Models;

namespace Users.Common.Services
{
    class UserService : IUserService
    {
        public IUser Get(string email)
        {
            throw new NotImplementedException();
        }

        public IUser Get(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IServiceResponse Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public IServiceResponse Register(IUser user)
        {
            throw new NotImplementedException();
        }

        public IServiceResponse SetPassword(Guid userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
