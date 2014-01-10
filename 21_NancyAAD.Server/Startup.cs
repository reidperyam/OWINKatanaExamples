using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.ActiveDirectory;

[assembly: OwinStartup(typeof(NancyAAD.Server.Startup))]

namespace NancyAAD.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWindowsAzureActiveDirectoryBearerAuthentication(
                        new WindowsAzureActiveDirectoryBearerAuthenticationOptions
                        {
                            Audience = "https://SalesApplication.onmicrosoft.com/NancyDemoServer",
                            Tenant = "SalesApplication.onmicrosoft.com"
                        })
                      .UseNancy();
        }
    }
}
