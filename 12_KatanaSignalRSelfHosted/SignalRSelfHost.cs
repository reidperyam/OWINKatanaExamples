using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaSignalRSelfHosted
{
    public class SignalRSelfHost
    {
        static string url = "http://localhost:9999";
        static void Main(string[] args)
        {
            if (args.Contains<string>("-url"))
            {
                url = GetUrl(args);
            }
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }

        private static string GetUrl(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-url" && args.Length > i + 1)
                {
                    return args[i + 1];
                }
            }
            return url;
        }
    }
}

