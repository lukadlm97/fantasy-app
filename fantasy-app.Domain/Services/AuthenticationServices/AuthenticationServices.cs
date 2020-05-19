using fantasy_app.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.AuthenticationServices
{
    public class AuthenticationServices : IAuthenticationService
    {
        public Task<string> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(string username, string password, string email, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
