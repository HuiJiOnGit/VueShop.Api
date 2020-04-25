using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Autofac;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SqlSugar;

namespace VueShop.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // ע��sqlsugar
            services.AddScoped<ISqlSugarClient>(option =>
            {
                var config = new ConnectionConfig()
                {
                    ConnectionString = Configuration.GetConnectionString("mydbConnectionString"),
                    DbType = DbType.MySql,
                    InitKeyType = InitKeyType.Attribute,//�����Զ�ȡ��������������Ϣ
                    IsAutoCloseConnection = true,//�����Զ��ͷ�ģʽ��EFԭ��һ���ҾͲ��������
                };
                return new SqlSugarClient(config);
            });
            // ���swagger
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("V1", new OpenApiInfo { Title = "VusShop.Api", Version = "v1" });
            });

            //���jwt��֤
            services.AddAuthentication(option =>
            {
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(option =>
            {
                var securityKey = Configuration["TokenSetting:SecurityKey"];
                var issuser = Configuration["TokenSetting:Issuer"];
                var audience = Configuration["TokenSetting:Audience"];
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = issuser,//������
                    ValidAudience = audience,//������
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey)),//��Կ
                    ClockSkew = TimeSpan.FromHours(1),//����ʱ��
                    ValidateLifetime = true,//�Ƿ���֤����ʱ��
                    ValidateIssuer = true,//�Ƿ���֤������
                    ValidateAudience = true,//�Ƿ���֤������
                };
            });
        }

        /// <summary>
        ///  autofac���񹤳�
        /// </summary>
        /// <param name="builder"></param>
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

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VusShop.Api v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}