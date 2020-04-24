using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VueShop.IServices;
using VueShop.Model.ViewModels;

namespace VueShop.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserServices userServices;
        private readonly ILogger<LoginController> logger;

        public LoginController(IUserServices userServices, ILogger<LoginController> logger)
        {
            this.userServices = userServices;
            this.logger = logger;
        }

        [HttpGet("getvalue")]
        public async Task<ActionResult<LoginViewModel>> GetValue()
        {
            var user = await userServices.Query(n => n.username == "admin");
            var result = new LoginViewModel();
            if (user != null)
            {
                foreach (var item in user)
                {
                    result.UserName = item.username;
                    result.Password = item.password;
                }
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginViewModel>> Login([FromBody] LoginViewModel loginView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await userServices.Query(n => n.username == loginView.UserName && n.password == loginView.Password);

            if (user != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}