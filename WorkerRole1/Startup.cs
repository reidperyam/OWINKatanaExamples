using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WorkerRole1.Startup))]

namespace WorkerRole1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
