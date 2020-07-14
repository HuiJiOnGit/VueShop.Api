using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using VueShop.Api.Extensions.Authorizations;
using VueShop.Services;

namespace VueShop.Api.Extensions
{
    /// <summary>
    /// 认证服务
    /// </summary>
    public static class AuthorizationSetup
    {
        /// <summary>
        /// authorization注册
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddAuthorizationSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException();
            }

            //添加jwt验证
            services.AddAuthentication(option =>
            {
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;//默认的认证方案
            })
            .AddJwtBearer(option =>
            {
                var securityKey = configuration["TokenSetting:SecurityKey"];
                var issuser = configuration["TokenSetting:Issuer"];
                var audience = configuration["TokenSetting:Audience"];
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = issuser,//发行人
                    ValidAudience = audience,//订阅人
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey)),//密钥
                    ClockSkew = TimeSpan.FromHours(1),//过期时间
                    ValidateLifetime = true,//是否验证过期时间
                    ValidateIssuer = true,//是否验证发行人
                    ValidateAudience = true,//是否验证订阅人
                };
            });

            #region 添加授权

            //1、直接在控制器或者方法上添加[authorize]就是简单的授权了,验证是否登录

            //2、基于角色的授权
            //[Authorize(Roles = "HRManager,Finance")]
            //public class SalaryController : Controller
            //基于策略的角色检查
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("RequireAdministratorRole",
            //         policy => policy.RequireRole("Administrator"));
            //});
            // 使用
            //[Authorize(Policy = "RequireAdministratorRole")]
            //public IActionResult Shutdown()
            //{
            //    return View();
            //}

            //3、基于声明的授权
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
            //});
            //[Authorize(Policy = "EmployeeOnly")]
            //public IActionResult VacationBalance()
            //{
            //    return View();
            //}

            //4、基于策略的授权
            //详细看这里 https://docs.microsoft.com/zh-cn/aspnet/core/security/authorization/policies?view=aspnetcore-3.1

            //var permissionRuquired = new PermissionRequirement
            //{
            //}

            //services.AddAuthorization(option =>
            //{
            //    option.AddPolicy("MyPermissions", policy => policy.Requirements.Add(new PermissionRequirement))
            //});

            #endregion 添加授权
        }
    }
}