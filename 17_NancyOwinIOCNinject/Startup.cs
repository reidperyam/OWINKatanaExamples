using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Nancy;
using Nancy.Owin;

namespace NancyOwinIOCNinject
{
    /// <summary>
    /// Install-Package Nancy.Bootstrappers.Ninject
    /// Install-Package Nancy 
    /// Install-Package Nancy.Owin 
    /// Install-Package OwinHost 
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
