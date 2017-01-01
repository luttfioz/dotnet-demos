using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Console.WriteLine("Listening on port 5000");
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(minLevel: LogLevel.Information);
            //app.UseUserAgentLogger();
            
            
            app.Use(async (context, next) =>
            {
                Console.WriteLine("Custom middleware logs request: " + context.Request.Path);
                await next();
                Console.WriteLine("Custom middleware logged");
            });

            app.Run(context =>
            {
                Console.WriteLine("0000000Apps Work");
                return context.Response.WriteAsync("Hello from ASP.NET !");
            });
        }

    }
}