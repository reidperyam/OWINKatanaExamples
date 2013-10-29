using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("Test",typeof(_3_OWINStartupClassDetection.TestStartup))]

namespace _3_OWINStartupClassDetection
{
    public class TestStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                string t = DateTime.Now.Millisecond.ToString();
                return context.Response.WriteAsync(t + " Test OWIN App");
            });
        }
    }
}
