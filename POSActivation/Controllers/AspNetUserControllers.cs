using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using POSActivation.DataService.Commons;
using POSActivation.DataService.Models;
using POSActivation.DataService.Services;
using POSActivation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSActivation.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/asp-user")]
    [ApiController]
    public class AspNetUserControllers : ControllerBase
    {
        private readonly IAspNetUserService aspNetUserService;
        private readonly UserManager<AspNetUser> _userManager;
        public AspNetUserControllers(IAspNetUserService _aspNetUserService, UserManager<AspNetUser> userManager)
        {
            aspNetUserService = _aspNetUserService;
            _userManager = userManager;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(AspNetUserViewModel aspNetUserViewModel)
        {
            var user = await _userManager.FindByNameAsync(aspNetUserViewModel.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, aspNetUserViewModel.Password))
            {
                return Ok(AccessTokenManager.GenerateJwtToken(user.UserName));
            }
            return BadRequest("Login fail");
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(AspNetUserViewModel asp)
        {
            var user = await _userManager.FindByNameAsync(asp.Username);
            if (user == null)
            {
                var IRs = await _userManager.CreateAsync(new AspNetUser
                {
                    UserName = asp.Username,
                    Id = Guid.NewGuid().ToString()
                }, asp.Password); ;
                if (IRs.Succeeded)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }
    }
}
