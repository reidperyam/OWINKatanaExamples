using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KatanaWindowsAuth.Startup))]

namespace KatanaWindowsAuth
{
    /// <summary>
    /// Install-Package Microsoft.Owin.Host.SystemWeb -pre 
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World from IIS OWIN Host with Windows Authentication Enabled!");
            });
        }
    }
}
