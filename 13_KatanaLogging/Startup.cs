using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;
using System.Diagnostics;

/// <summary>
/// Microsoft.Owin
/// Owin
/// OwinHost
/// </summary>
namespace KatanaLogging
{
    using LoggingSample.Logging;
    using TraceFactoryDelegate = Func<string, Func<TraceEventType, int, object, Exception, Func<object, Exception, string>, bool>>;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Log1(app);
            app.Use<MyCustomMiddleware>(app);
        }

        private void Log1(IAppBuilder app)
        {
            ILogger logger = app.CreateLogger<Startup>();
            logger.WriteError("App is starting up");
            logger.WriteCritical("App is starting up");
            logger.WriteWarning("App is starting up");
            logger.WriteVerbose("App is starting up");
            logger.WriteInformation("App is starting up");

            int foo = 1;
            int bar = 0;

            try
            {
                int fb = foo / bar;
            }
            catch (Exception ex)
            {
                logger.WriteError("Error on calculation", ex);
            }
        }
    }

    public class MyCustomMiddleware : OwinMiddleware
    {
        private readonly ILogger _logger;

        public MyCustomMiddleware(OwinMiddleware next, IAppBuilder app)
            : base(next)
        {
            _logger = app.CreateLogger<MyCustomMiddleware>();
        }

        public override Task Invoke(IOwinContext context)
        {
            _logger.WriteVerbose(
                string.Format("{0} {1}: {2}",
                context.Request.Scheme,
                context.Request.Method,
                context.Request.Path));

            context.Response.Headers.Add(
                "Content-Type", new[] { "text/plain" });

            return context.Response.WriteAsync(
                "Logging sample is running!");
        }
    }
}
