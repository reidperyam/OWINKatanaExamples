using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _5_KatanaASPNETWebAPI
{
    public class DefaultController : ApiController
    {
        public string Get()
        {
            return "Hello World from ASP.NET Web API OWIN Self-Host";
        }
    }

}