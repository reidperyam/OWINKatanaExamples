using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Nancy.Owin;
using Nancy;
using Microsoft.Owin.Diagnostics;

namespace OWINNancyPassthrough
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Nancy in an OWIN pipeline is, by default, terminating. That is, when it fails to resolve a handler or static content, it will complete the request 
            // and return a 404. Subsequent middleware will not be invoked
            // http://tinyurl.com/l7dpo37
            // so in the following commented-out code, UseWelcomePage() will not be used
            // app
            //.UseNancy()
            //.UseWelcomePage();

            // In order to configure Nancy to pass-through, you can supply a delegate that is invoked on a per-request basis,
            // after it has been initially handled by Nancy: 

            // Here, when Nancy is responding with a 404, the request is passed-through to UseOtherMiddleware and Nancy's response (any headers and body) is discarded. 
            app.UseNancy(options =>
                  options.PerformPassThrough = context =>
                      context.Response.StatusCode == HttpStatusCode.NotFound)
              .UseWelcomePage();
        }
    }
}
