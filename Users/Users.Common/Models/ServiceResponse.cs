using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Common.Models
{
    class ServiceResponse : IServiceResponse
    {
        public bool Success { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Exception Exception { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
