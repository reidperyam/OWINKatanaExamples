using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_1_IISOWINHost.Startup))]

namespace _1_IISOWINHost
{
    /// <summary>
    /// install-package Microsoft.Owin.Host.SystemWeb –Pre
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // This code adds a simple piece of middleware to the OWIN pipeline, implemented 
            // as a function that receives a Microsoft.Owin.IOwinContext instance. When the 
            // server receives an HTTP request, the OWIN pipeline invokes the middleware. 
            // The middleware sets the content type for the response and writes the response body. 
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world from the IIS OWIN Host");
            });
        }
    }
}
