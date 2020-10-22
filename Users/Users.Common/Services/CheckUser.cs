using System;
using System.Collections.Generic;
using System.Text;
using Users.Common.Models;

namespace Users.Common.Services
{
    class CheckUser : IServiceResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
