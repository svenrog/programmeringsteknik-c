using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Common.Models
{
    public class User : IUser
    {
        public Guid Id { get ; set ; }
        public string Name { get ; set ; }
        public string Email { get ; set ; }
        public string Phone { get ; set ; }
        public bool SubscribeToNewsletter { get ; set ; }
    }
}
