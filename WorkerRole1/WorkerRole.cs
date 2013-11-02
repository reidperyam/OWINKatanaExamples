using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.Owin;
using Nancy.Owin;
using Microsoft.Owin.Hosting;

namespace WorkerRole1
{
    public class WorkerRole : RoleEntryPoint
    {
        private IDisposable MyApp = null;

        public override void Run()
        {
            // This is a sample worker implementation. Replace with your logic.
            Trace.TraceInformation("WorkerRole1 entry point called", "Information");

            while (true)
            {
                Thread.Sleep(10000);
                Trace.TraceInformation("Working", "Information");
            }
        }

        public override bool OnStart()
        {
            ServicePointManager.DefaultConnectionLimit = 50;
            var AppPoint = RoleEnvironment.CurrentRoleInstance.InstanceEndpoints["OwinEndpoint"];
            string baseUri = string.Format("{0}://{1}", AppPoint.Protocol, AppPoint.IPEndpoint);
            Trace.TraceInformation(String.Format("OWIN URL is {0}", baseUri), "Information");
            MyApp = WebApp.Start<Startup>(new StartOptions(url: baseUri));

            return base.OnStart();
        }

        public override void OnStop()
        {
            if (MyApp != null)
            {
                MyApp.Dispose();
            }
            base.OnStop();
        }
    }
}
