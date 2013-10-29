using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Nancy;
using Nancy.Conventions;
using Nancy.Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(_8_BigKatana.Startup))]

namespace _8_BigKatana
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("bugs", "api/{Controller}");
            app.UseWebApi(config);

            app.UseNancy(options =>
            {
                options.Bootstrapper = new CustomBootstrapper();
            });
        }

        public class CustomBootstrapper : DefaultNancyBootstrapper
        {
            protected override void ConfigureConventions(NancyConventions nancyConventions)
            {
                base.ConfigureConventions(nancyConventions);

                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("scripts", "Scripts"));
            }
        }
    }
}
