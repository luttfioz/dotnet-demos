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
            //Single instance created
            services.AddSingleton<ICalculator, Calculator>();
            
            //New object created every time it is requested
            //services.AddTransient<ITransient, Transient>();
            //New object created for each request (scoped to the request)
            //services.AddScoped<IScoped, Scoped>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }

    }
}