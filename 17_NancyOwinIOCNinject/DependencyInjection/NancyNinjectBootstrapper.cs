using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Bootstrappers.Ninject;
using Ninject.Modules;
using Ninject;

namespace NancyOwinIOCNinject.DependencyInjection
{
    // here's where we intercept Nancy's default IoC container's (TinyIOC) default functionality
    // from the execution pipeline and bootstrap in our own -- Ninject
    public class NancyNinjectBootstrapper : NinjectNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(IKernel existingContainer)
        {
            // let's load our defined bindings into the kernel
            existingContainer.Load(new NinjectInjectionModule());

            // and let Nancy handle the integration as wel continue through the pipeline
            base.ConfigureApplicationContainer(existingContainer);
        }
    }
}