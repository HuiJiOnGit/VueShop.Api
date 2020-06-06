using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;

namespace VueShop.Api.Extensions
{
    public static class SqlsugarSetup
    {
        public static void AddSqlsugarSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException();
            }

            // 注入sqlsugar
            services.AddScoped<ISqlSugarClient>(option =>
            {
                var config = new ConnectionConfig()
                {
                    ConnectionString = configuration.GetConnectionString("mydbConnectionString"),
                    DbType = DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                    IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
                };
                return new SqlSugarClient(config);
            });
        }
    }
}