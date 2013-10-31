using System;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Diagnostics;

namespace OWINUseErrorPage
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
// useful usage as a suggestion
//#if DEBUG
            app.UseErrorPage();
//#endif
            WelcomePageOptions options = new WelcomePageOptions();
            options.Path = new PathString("/welcome");
            app.UseWelcomePage(options);

            app.Run(context =>
            {
                // New code: Throw an exception for this URI path.
                if (context.Request.Path.Value.ToLower() == "/fail")
                {
                    throw new Exception("My Error");
                }

                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world! Navigate to /welcome for happy blue thing navigate to /fail for katana error explosion output formatting");
            });       
        }
    }
}
