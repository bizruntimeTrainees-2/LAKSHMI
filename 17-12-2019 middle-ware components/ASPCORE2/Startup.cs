using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPCORE2
{
    public class Startup
    {
        public int SourceCodeLineCount { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            /*
            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("page1.html");
            app.UseFileServer(fileServerOptions);
            */
            /*
             * by using fileServerOptions we will get combination of both
            StaticFilesEndpointRouteBuilderExtensions and defaultFiles */
            /*
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("page1.html");
            //here we pass object by getting value of page1.html
            app.UseDefaultFiles(defaultFilesOptions);//This is another piece of middleware
            app.UseStaticFiles();//by using static files , here we get images or css files
            */
            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }
            else if(env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT"))//UAT method is used only for environment variable
            {
                app.UseExceptionHandler("/Error");  //it will display friendly error page
            }
            app.UseStaticFiles();
            
            app.Run(async (context) =>
            {
                //throw new Exception("some error processing the request");
                //here if we throw exception but we did not get exception
                    await context.Response.WriteAsync("Hosting Environment:" + env.EnvironmentName);
                    //it will display the environment name what is present in the launch json file.
                
            });
            
        }
    }
}
