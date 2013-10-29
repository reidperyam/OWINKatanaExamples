using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(_5_KatanaASPNETWebAPI.Startup))]

namespace _5_KatanaASPNETWebAPI
{
    /// <summary>
    /// Self-Hosted Web API
    /// Install-Package Microsoft.AspNet.WebApi.Owin –pre
    /// Install-Package Microsoft.AspNet.WebApi.OwinSelfHost –Pre
    /// start process then navigate to /api/default
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                         name: "DefaultApi",
                         routeTemplate: "api/{controller}/{id}",
                         defaults: new { id = RouteParameter.Optional }
                     );

            app.UseWebApi(config); 
        }
    }
}
