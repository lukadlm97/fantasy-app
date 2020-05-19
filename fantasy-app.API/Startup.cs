using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fantasy_app.Domain.Services;
using fantasy_app.Domain.Services.AuthenticationServices;
using fantasy_app.Domain.Services.PasswordServices;
using fantasy_app.EntityFramework;
using fantasy_app.EntityFramework.Services;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace fantasy_app.API
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy(MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            services.AddControllers().AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
              );

            services.AddSingleton<DesignTimeDbContextFactory>();
            services.AddSingleton<IAuthenticationService, AuthenticationServices>();
            services.AddSingleton<IPasswordService, PasswordService>();
            services.AddSingleton<IAccountService, AccountService>();
        
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
