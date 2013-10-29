using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IO;

// removing this explicit Startup expression to force Startup discovery
//[assembly: OwinStartup(typeof(_11_OWINStartupClassDetection.Startup))]

namespace OWINStartupClassDetection
{
    /// <summary>
    /// Install-Package Microsoft.Owin.Host.SystemWeb
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The app.Use lambda expression is used to register the specified middleware component to the OWIN  pipeline. 
        /// In this case we are setting up logging of incoming requests before responding to the incoming request. 
        /// The next  parameter is the delegate (  Func<Task> ) to the next component in the pipeline. The app.Run lambda 
        /// expression hooks up the pipeline to incoming requests and provides the response mechanism. Note: In the code 
        /// above we have commented out the OwinStartup attribute and we're relying on the convention of running the class named Startup.
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            app.Use((context, next) =>
            {
                TextWriter output = context.Get<TextWriter>("host.TraceOutput");
                return next().ContinueWith(result =>
                {
                    output.WriteLine("Scheme {0} : Method {1} : Path {2} : MS {3}",
                    context.Request.Scheme, context.Request.Method, context.Request.Path, getTime());
                });
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync(getTime() + " My First OWIN App");
            });
        }

        string getTime()
        {
            return DateTime.Now.Millisecond.ToString();
        }
    }
}
