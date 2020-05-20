using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services
{
    public interface IAccountService
    {
        Task<IdentityUser> GetByUsername(string username);
        Task<IdentityUser> GetByEmail(string email);
        Task<string> Register(string username, string password, string email, string phone);
        Task<string> Login(string username, string password);
    }
}
