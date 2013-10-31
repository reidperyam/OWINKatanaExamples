using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

using Ninject;
using NancyOwinIOCNinject.DependencyInjection;

namespace NancyOwinIOCNinject
{
    public class DefaultModule : NancyModule
    {
        IEnumerable<IPerson> _persons;

        // this is a simple demonstration of constructor injection using Ninject...
        public DefaultModule(IEnumerable<IPerson> persons)
        {
            _persons = persons;

            Get["/"] = _ =>
            {
                return "Hello World! Navigate to /persons !";
            };

            Get["/persons"] = _ =>
            {
                return Response.AsJson<IEnumerable<IPerson>>(_persons);
            };
        }
    }
}