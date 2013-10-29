using Microsoft.AspNet.SignalR;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

//[assembly: OwinStartup(typeof(KatanaSignalRSelfHosted.Startup))]

namespace KatanaSignalRSelfHosted
{
    /// <summary>
    /// Install-Package Microsoft.AspNet.SignalR.Owin
    /// Install-Package Microsoft.Owin.Hosting –pre 
    /// Install-Package Microsoft.Owin.Host.HttpListener –pre
    /// Install-Package Microsoft.Owin.StaticFiles -Version 0.20.0-alpha-20220-88 -Pre 
    /// install-package Microsoft.AspNet.SignalR.JS 
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Turn cross domain on 
            var config = new HubConfiguration { EnableCrossDomain = true };
            // This will map out to http://localhost:9999/signalr 
            app.MapHubs(config);

            //Note: We are dealing with the ‘bleeding edge’ here as in most of the Katana Owin components 
            // are Beta or Alpha release. The Static HTML Hosting is an alpha release. So expect some tweaks 
            // when things go live late in 2013. 
            // Install-Package Microsoft.Owin.StaticFiles –version 0.20-alpha-20220-88 
            string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string webFolder = Path.Combine(exeFolder, "Web");
            app.UseStaticFiles(webFolder);
            // http://localhost:9999/Home.html 
        }
    }
}
