using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace VueShop.Api.Extensions
{
    /// <summary>
    /// swagger
    /// </summary>
    public static class SwaggerSetup
    {
        /// <summary>
        /// swagger
        /// </summary>
        /// <param name="services"></param>
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException();
            }

            // 添加swagger
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("V1", new OpenApiInfo { Title = "VusShop.Api", Version = "v1" });
            });
        }
    }
}