using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KatanaConsoleHost.Startup))]

namespace KatanaConsoleHost
{
    /// <summary>
    /// Install-Package Microsoft.Owin.Diagnostics 
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            // Microsoft.Owin.Diagnostics allows for these guys:
#if DEBUG
            app.UseErrorPage();
#endif
            app.UseWelcomePage("/");
        }

    }
}
