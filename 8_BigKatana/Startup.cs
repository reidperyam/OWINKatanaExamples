using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Nancy;
using Nancy.Conventions;
using Nancy.Owin;
using Nancy.Diagnostics;
using System.Web.Http;
using Microsoft.Owin.Extensions;

[assembly: OwinStartup(typeof(BigKatana.Startup))]

namespace BigKatana
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
            app.UseStageMarker(PipelineStage.MapHandler);
        }

        public class CustomBootstrapper : DefaultNancyBootstrapper
        {
            protected override void ConfigureConventions(NancyConventions nancyConventions)
            {
                base.ConfigureConventions(nancyConventions);

                StaticConfiguration.EnableRequestTracing = true;  

                Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("scripts", "Scripts"));
            }

            protected override DiagnosticsConfiguration DiagnosticsConfiguration
            {
                get { return new DiagnosticsConfiguration { Password = @"Artery22" }; }
            }
        }
    }
}
