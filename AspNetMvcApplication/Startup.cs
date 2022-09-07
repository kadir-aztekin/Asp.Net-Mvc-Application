using AspNetMvcApplication.Extensions;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcApplication
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllersWithViews()//mvc calýsacagýný soyledýk
                .AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>()); 
            //git sisteme bak validatasyon varsa çalýþtýr
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHello();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles(); //wwwroot kullanmak ýcin

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("Default", "{controller=Product}/{action=Create}");
                //endpoints.MapControllerRoute("default2", "anasayfa", new { controller = "home", action = "ýndex" });
                //endpoints.MapControllerRoute("Default3", "Create", new { controller = "Product", action = "Create" });
                endpoints.MapDefaultControllerRoute();

            });
        }
    }
}
