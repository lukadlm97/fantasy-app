using fantasy_app.Domain.Services.AuthenticationServices;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.AuthenticationServices
{
    public class AuthenticationServices : IAuthenticationService
    {
        private readonly IAccountService _accountService;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticationServices(IAccountService accountService,IPasswordHasher passwordHasher)
        {
            _accountService = accountService;
            _passwordHasher = passwordHasher;
        }

        public Task<string> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(string username, string password, string email, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
