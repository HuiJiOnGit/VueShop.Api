using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using VueShop.Model.ViewModels;

namespace VueShop.Api.AuthorizationHelper.Jwt
{
    public class JwtHelper
    {
        private readonly IConfiguration configuration;

        public JwtHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public static string CreateJwt(string userName)
        {
            var (key, iss, aud) = new ValueTuple<string, string, string>("zheshiyige16weidemiyao", "http://localhost:5000", "http://localhost:5000");

            // 1.先声明claim
            var claims = new Claim[]
            {
                // 用户名
                new Claim(ClaimTypes.Name,userName),
                // 不早于这个时间
                new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                // 过期时间
                new Claim (System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddMinutes(30)).ToUnixTimeSeconds()}"),
                // 用户的角色
                new Claim(ClaimTypes.Role,"admin")
            };

            //2 .将密钥转signingCredentials签署凭证
            var tkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var sicr = new SigningCredentials(tkey, SecurityAlgorithms.HmacSha256);

            // 3.声明jwttoken

            var jwt = new JwtSecurityToken(
                issuer: iss,
                audience: aud,
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: sicr
                );

            //4.生成token
            var encodeJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodeJwt;
        }
    }
}