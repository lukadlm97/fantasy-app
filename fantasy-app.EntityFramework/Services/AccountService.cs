using fantasy_app.Domain.Services;
using fantasy_app.Domain.Services.TokenServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;


namespace fantasy_app.EntityFramework.Services
{
    public class AccountService:IAccountService
    {
       
        private readonly DesignTimeDbContextFactory _contextFactory;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger _logger;
        private readonly ITokenService _tokenService;

        public AccountService(DesignTimeDbContextFactory contextFactory, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ILogger logger)
        {
            _contextFactory = contextFactory;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public Task<IdentityUser> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(string username, string password, string email, string phone)
        {
            using(ApplicationDbContext context = _contextFactory.CreateDbContext(null))
            {
                var user = new IdentityUser { UserName = username, Email = email };

                user.EmailConfirmed = true;

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password");

                    

                    _tokenService.GenerateAccessToken()

                }
            }
        }

        Task<Microsoft.AspNet.Identity.EntityFramework.IdentityUser> IAccountService.GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        Task<Microsoft.AspNet.Identity.EntityFramework.IdentityUser> IAccountService.GetByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
