using fantasy_app.Domain.Services.AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.AuthenticationServices
{
    public class AuthenticationServices : IAuthenticationService
    {
        private readonly IAccountService _accountService;

        public AuthenticationServices(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Task<string> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(string username, string password, string email, string phoneNumber)
        {
            if(await _accountService.Register(username, password, email, phoneNumber))
            {
                return "token";
            }
            else
            {
                return "false";
            }
        }
    }
}
