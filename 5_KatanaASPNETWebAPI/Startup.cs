using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(KatanaASPNETWebAPI.Startup))]

namespace KatanaASPNETWebAPI
{
    /// <summary>
    /// Self-Hosted Web API
    /// Install-Package Microsoft.AspNet.WebApi.Owin –pre
    /// Install-Package Microsoft.AspNet.WebApi.OwinSelfHost –Pre
    /// start process then navigate to http://localhost:2411/api/default
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Install-Package Microsoft.Owin.Diagnostics
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                         name: "DefaultApi",
                         routeTemplate: "api/{controller}/{id}",
                         defaults: new { id = RouteParameter.Optional }
                     );

            app.UseWebApi(config);

            // Microsoft.Owin.Diagnostics
            app.UseWelcomePage("/");
        }
    }
}
