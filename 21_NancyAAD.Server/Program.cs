using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyAAD.Server
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Microsoft.Owin.Hosting;

    internal class Program
    {
        public static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9000/"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("NancyDemoServer listening at http://localhost:9000/");
                Console.WriteLine("Press ENTER to terminate");
                Console.ReadLine();
            }
        }
    }
}
