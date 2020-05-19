using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<string> Register(string username, string password,string email,string phoneNumber);
        Task<string> Login(string username, string password);
    }
}
