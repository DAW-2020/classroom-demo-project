using DAW.Entities;
using DAW.IServices;
using Laborator4_453.Helpers;
using Laborator4_453.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(AuthenticationRequest request)
        {
            return Ok(_userService.Register(request));
        }

        [HttpPost("login")]
        public IActionResult Login(AuthenticationRequest request)
        {
            return Ok(_userService.Login(request));
        }

        [HttpGet("isAuth")]
        [Authorize]
        public IActionResult IsAuth()
        {
            return Ok(true);
        }
    }

}
