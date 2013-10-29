using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;

namespace _6_KatanaConsoleHost
{
    /// <summary>
    /// Install-Package Microsoft.Owin.SelfHost -Pre
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:12345/";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");

                // Open the browser
                Process.Start(uri);

                // Press any key to stop the server
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }
        }
    }
}
