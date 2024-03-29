﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Models;

namespace RestaurantWebsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime.
        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Added the following 2 lines of code for assignment3!!!!!!!!
            services.AddDbContext<RestaurantContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("RestaurantContext")));
              //options.UseSqlServer(Configuration.GetConnectionString("RestaurantContext")));





            //URLs lowercase and end with a trailing slash
            services.AddRouting(options => {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

        }

        // This method gets called by the runtime.
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
            });
        }
    }
}


