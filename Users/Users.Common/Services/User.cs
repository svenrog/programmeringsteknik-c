using System;
using System.Collections.Generic;
using System.Text;
using Users.Common.Models;

namespace Users.Common.Services
{
    public class User : IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool SubscribeToNewsletter { get; set; } = true;
    }
}
