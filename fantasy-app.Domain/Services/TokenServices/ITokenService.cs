using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace fantasy_app.Domain.Services.TokenServices
{
    public interface ITokenService
    {
        string GenerateAccessToken();
        
    }
}
