using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace VueShop.Api.Extensions
{
    /// <summary>
    /// 认证服务
    /// </summary>
    public static class AuthorizationSetup
    {
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
        }
    }
}