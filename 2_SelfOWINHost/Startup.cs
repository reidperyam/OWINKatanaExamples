using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_2_SelfOWINHost.Startup))]

namespace _2_SelfOWINHost
{
    /// <summary>
    /// Install-Package Microsoft.Owin.SelfHost -Pre
    /// install-package Microsoft.Owin.Diagnostics –Pre
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // New code: Add the error page middleware to the pipeline. 
            // The Microsoft.Owin.Diagnostics package contains middleware that catches unhandled 
            // exceptions and displays an HTML page with error details. This page functions much 
            // like the ASP.NET error page that is sometimes called the “yellow screen of death” 
            // (YSOD). Like the YSOD, the Katana error page is useful during development, but it’s 
            // a good practice to disable it in production mode.
            app.UseErrorPage();

            app.Run(context =>
            {
                // New code: Throw an exception for this URI path.
                if (context.Request.Path.ToString() == "/fail")
                {
                    throw new Exception("Random exception");
                }

                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world from Microsoft.Owin.SelfHost");
            });
        }
    }
}
