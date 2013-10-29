using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Diagnostics;

[assembly: OwinStartup(typeof(OWINHostAndVisualStudioIntegration.Startup))]

namespace OWINHostAndVisualStudioIntegration
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseWelcomePage();
        }
    }
}
