using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fantasy_app.Domain.Services
{
    public interface IAccountService:IDataService<IdentityUser>
    {
        Task<IdentityUser> GetByUsername(string username);
        Task<IdentityUser> GetByEmail(string email);
        Task<bool> Register(string username, string password, string email, string phone);
    }
}
