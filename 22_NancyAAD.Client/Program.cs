using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace NancyAAD.Client
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Microsoft.WindowsAzure.ActiveDirectory.Authentication;

    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client ready.");
            Console.WriteLine("Press any key to invoke the service");
            Console.WriteLine("Press ESC to terminate");
            ConsoleKeyInfo consoleKeyInfo;

            var authenticationContext = new AuthenticationContext("https://login.windows.net/SalesApplication.onmicrosoft.com");

            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                // get the access token
                AuthenticationResult authenticationResult = authenticationContext.AcquireToken(
                    "https://SalesApplication.onmicrosoft.com/WebApplication1",
                    "5685ff14-3fb8-4785-a78e-6f81219b39f8",
                    "https://SalesApplication.onmicrosoft.com/myWebAPItestclient");

                // invoke the Nancy API
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authenticationResult.AccessToken);
                HttpResponseMessage response = httpClient.GetAsync("http://localhost:9000/values").Result;
                // display the result
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("==> Successfully invoked the service");
                    Console.WriteLine(result);
                }
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}