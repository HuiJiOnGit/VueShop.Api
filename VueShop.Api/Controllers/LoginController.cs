using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VueShop.Api.AuthorizationHelper.Jwt;
using VueShop.IServices;
using VueShop.Model.ViewModels;

namespace VueShop.Api.Controllers
{
    /// <summary>
    /// login
    /// </summary>
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserServices userServices;
        private readonly ILogger<LoginController> logger;
        private readonly JwtHelper jwtHelper;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="userServices"></param>
        /// <param name="logger"></param>
        /// <param name="jwtHelper"></param>
        public LoginController(IUserServices userServices, ILogger<LoginController> logger, JwtHelper jwtHelper)
        {
            this.userServices = userServices;
            this.logger = logger;
            this.jwtHelper = jwtHelper;
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="loginViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = await userServices.GetUser(loginViewModel);
            if (user != null)
            {
                string result = $"Beaner {jwtHelper.CreateJwt(user.UserName)}";
                return Ok(result);
            }
            return NotFound();
        }
    }
}