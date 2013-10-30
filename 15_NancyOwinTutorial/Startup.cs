using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(NancyOwinTutorial.Startup))]

namespace NancyOwinTutorial
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // bootup the bitch
            app.UseNancy();
        }
    }
}
