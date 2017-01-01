using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //app.UseMvc();
            /*
            app.UseMvc(routes =>
                {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                });
            */
            app.UseMvcWithDefaultRoute();
            //UseMvcWithDefaultRoute Home/Index seklinde default mvc pattern olusur.
        }

    }
}