using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Penguin.Authentication.Abstractions.Interfaces
{
    public interface IAuthenticator
    {
        Task<AuthenticationResult> Authenticate(string Username, string Password);
    }
}
