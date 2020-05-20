using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace fantasy_app.Domain.Services.TokenServices
{
    public class TokenService : ITokenService
    {
       
        public string GenerateAccessToken()
        {
            throw new Exception();
        }
    }
}
