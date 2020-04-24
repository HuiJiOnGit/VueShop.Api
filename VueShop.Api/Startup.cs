using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SqlSugar;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Repository;
using VueShop.Services;

namespace VueShop.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // 注入sqlsugar
            services.AddScoped<ISqlSugarClient>(option =>
            {
                var config = new ConnectionConfig()
                {
                    ConnectionString = Configuration.GetConnectionString("mydbConnectionString"),
                    DbType = DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                    IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
                };
                return new SqlSugarClient(config);
            });
        }

        // autofac服务工厂
        public void ConfigureContainer(ContainerBuilder builder)
        {
            Assembly services = Assembly.Load("VueShop.Services");
            Assembly repository = Assembly.Load("VueShop.Repository");
            builder.RegisterAssemblyTypes(services)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
            builder.RegisterAssemblyTypes(repository)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}