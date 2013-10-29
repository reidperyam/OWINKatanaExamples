using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;
using System.Web;
using System.IO;

namespace OWINMiddlewareInIISPipeline
{
    /// <summary>
    ///  Install-Package Microsoft.Owin.Host.SystemWeb
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The Startup configuration sets up a pipeline with three middleware components, the first two displaying diagnostic information
        /// and the last one responding to events (and also displaying diagnostic information).  The PrintCurrentIntegratedPipelineStage 
        /// method displays the integrated pipeline event this middleware is invoked on and a message.
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            app.Use((context, next) =>
            {
                PrintCurrentIntegratedPipelineStage(context, "Middleware 1");
                return next.Invoke();
            });
            app.Use((context, next) =>
            {
                PrintCurrentIntegratedPipelineStage(context, "2nd MW");
                return next.Invoke();
            });
            // You can mark OMCs to execute at specific stages of the pipeline by using the IAppBuilder UseStageMarker() extension method.
            // To run a set of middleware components during a particular stage, insert a stage marker right after the last component is the set 
            // during registration. There are rules on which stage of the pipeline you can execute middleware and the order components must run 
            // (The rules are explained later in the tutorial). Add the UseStageMarker method to the Configuration code as shown below:
            app.UseStageMarker(PipelineStage.Authenticate);

            app.Run(context =>
            {
                PrintCurrentIntegratedPipelineStage(context, "3rd MW");
                return context.Response.WriteAsync("Hello world");
            });
            app.UseStageMarker(PipelineStage.ResolveCache);
        }
        private void PrintCurrentIntegratedPipelineStage(IOwinContext context, string msg)
        {
            var currentIntegratedpipelineStage = HttpContext.Current.CurrentNotification;
            context.Get<TextWriter>("host.TraceOutput").WriteLine(
                "Current IIS event: " + currentIntegratedpipelineStage
                + " Msg: " + msg);
        }
    }
}
