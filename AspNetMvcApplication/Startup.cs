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
                .AddControllersWithViews()//mvc cal�sacag�n� soyled�k
                .AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>()); 
            //git sisteme bak validatasyon varsa �al��t�r
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles(); //wwwroot kullanmak �cin

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
                //endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{id?}/{a}/{b}/{id}");

                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute("Default","{contoller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
