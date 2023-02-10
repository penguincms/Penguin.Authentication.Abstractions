using System;

namespace Penguin.Authentication.Abstractions
{
    public class AuthenticationResult
    {
        public bool IsValid { get; set; }

        public Exception Exception { get; set; }
    }
}