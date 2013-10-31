using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;

namespace NancyOwinTutorial
{
    // !!!! Note !!!! - if you wanted to further configure Nancy's default IoC container (TinyIoC) this is how you 
    // would bootstap into it...
    // we don't need to though because Nancy is smart enough to figure out our bindings between interfaces and
    // implementations implicitly!!
    // For a more in depth usage example of this sort of functionality - checkout the next .csproj in this solution,
    // 17_NancyOwinIOCNinject

    //public class NancyBootstrapper : DefaultNancyBootstrapper
    //{
    //    protected override void ConfigureApplicationContainer(TinyIoCContainer container)
    //    {
    //        base.ConfigureApplicationContainer(container);
    //    }
    //    protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
    //    {
    //        base.ApplicationStartup(container, pipelines);
    //    }
    //}
}