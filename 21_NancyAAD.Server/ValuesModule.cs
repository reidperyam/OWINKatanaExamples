using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Nancy.Security;

namespace NancyAAD.Server
{
    using Nancy;

    public class ValuesModule : NancyModule
    {
        public ValuesModule()
        {
            this.RequiresMSOwinAuthentication();
            Get["/values"] = _ =>
            {
                ClaimsPrincipal claimsPrincipal = Context.GetMSOwinUser();
                Console.WriteLine("==>I have been called by {0}", claimsPrincipal.FindFirst(ClaimTypes.Upn));
                return new[] { "value1", "value2" };
            };
        }
    }
}
