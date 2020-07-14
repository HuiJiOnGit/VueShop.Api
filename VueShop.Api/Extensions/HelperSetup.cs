using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using VueShop.Api.AuthorizationHelper.Jwt;

namespace VueShop.Api.Extensions
{
    /// <summary>
    /// 各类help
    /// </summary>
    public static class HelperSetup
    {
        /// <summary>
        /// help注入
        /// </summary>
        /// <param name="services"></param>
        public static void AddHelpSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException();
            }
            // jwt帮助类注入
            services.AddSingleton<JwtHelper>();
        }
    }
}