using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace BigKatana
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                var model = new { title = "We've Got Issues..." };
                return View["home", model];
            };
        }
    }
}