using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Books_store
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // if we want to tell our application to tell that we want to use MVC as design pattern then we should follow the below steps
            // This can be done using tow methods 
            //1 first one
            //services.AddMvc();
            //2 method is 
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("This is my first middleware\n");
                await next();
                await context.Response.WriteAsync("This is the code after first middleware\n");

            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("This is my second middleware\n");
                await next();
                await context.Response.WriteAsync("This is the code after the second middleware\n");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("This is the last middleware\n");

            });*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/
            });
        }
    }
}
