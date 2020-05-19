using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fantasy_app.API.Models.AccountViewModels;
using fantasy_app.Domain.Services.AuthenticationServices;
using fantasy_app.Domain.Services.PasswordServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fantasy_app.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IPasswordService _passwordService;

        public UserController(IAuthenticationService authenticationService, IPasswordService passwordService)
        {
            _authenticationService = authenticationService;
            _passwordService = passwordService;

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel registerUser)
        {
            if (_passwordService.CheckIsPasswordIsConfirmed(registerUser.Password, registerUser.ConfirmPassword))
            {
                return BadRequest(new { message="Not confirmed password"});
            }
            if (string.IsNullOrEmpty(await _authenticationService.Register(registerUser.Username,registerUser.Password,registerUser.Email,registerUser.Phone)))
            {
                return BadRequest(new { message="Cant register user."});
            }
            return Ok();
        }
    }
}