using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_6_KatanaConsoleHost.Startup))]

namespace _6_KatanaConsoleHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {


#if DEBUG
            app.UseErrorPage();
#endif
            app.UseWelcomePage("/");
        }

    }
}
