using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders; 
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace aspemptyapp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
           /* services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();

            #region useimages
            // app.UseStaticFiles(new StaticFileOptions
            // {
            //     // Requires the following import:
            //     // using System.IO;
            //     // using Microsoft.Extensions.FileProviders;
            //     FileProvider = new PhysicalFileProvider(
            //             Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")),
            //     RequestPath = "/MyImages",

            //     OnPrepareResponse = ctx =>
            //     {
            //         ctx.Context.Response.Headers.Append("Cache-Control", "public,max-age=600");
            //     }
            // });
            #endregion
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
            });
        }
    }
}
