using fantasy_app.Domain.Services;
using fantasy_app.EntityFramework.Services.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace fantasy_app.EntityFramework.Services
{
    public class AccountService
    {
       
        private readonly DesignTimeDbContextFactory _contextFactory;
      

        public AccountService(DesignTimeDbContextFactory dbContext)
        {
             _contextFactory = dbContext;     
        }

        public async Task<bool> Register(string username,string password,string email,string phone)
        {
            var user = new IdentityUser
            { 
                UserName = username,
                Email = email,
                PhoneNumber = phone,
                NormalizedEmail = email.ToLower(),
                NormalizedUserName = username.ToLower()
            };

            using(ApplicationDbContext context = _contextFactory.CreateDbContext(null))
            {
                EntityEntry<IdentityUser> entity = await context.Set<IdentityUser>().AddAsync(user);
                await context.SaveChangesAsync();

                return entity.IsKeySet;
            }
        }

        
    }
}
