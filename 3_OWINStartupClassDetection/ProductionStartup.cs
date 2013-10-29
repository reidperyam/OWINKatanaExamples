using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("Production",typeof(_3_OWINStartupClassDetection.ProductionStartup))]

namespace _3_OWINStartupClassDetection
{
    public class ProductionStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                string t = DateTime.Now.Millisecond.ToString();
                return context.Response.WriteAsync(t + " Production OWIN App");
            });
        }
    }
}