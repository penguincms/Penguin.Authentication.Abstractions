using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Authentication.Abstractions
{
    public class AuthenticationResult
    {
        public bool IsValid { get; set; }
        public Exception Exception { get; set; }
    }
}
