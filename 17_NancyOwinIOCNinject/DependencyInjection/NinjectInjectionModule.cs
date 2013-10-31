using System;
using Ninject.Modules;

namespace NancyOwinIOCNinject.DependencyInjection
{
    /// <summary>
    /// explanation of Ninject multi-injection http://tinyurl.com/kfhvuzy
    /// </summary>
    public class NinjectInjectionModule : NinjectModule 
    {
        public override void Load()
        {
            // bind IPerson to an explicit instance of the Person class 
            // based on the arguments we define
            Bind<IPerson>().To<Person>()
                .WithConstructorArgument("name", "Robert Norwick")
                .WithConstructorArgument("birthday", new DateTime(1973, 12, 3).Date.ToString());

            //// create a Cyborg in the same way
            Bind<IPerson>().To<Cyborg>()
                .WithConstructorArgument("idNumber", Guid.NewGuid().ToString())
                .WithConstructorArgument("creationDate", new DateTime(2147, 3, 29).Date.ToString());
        }
    }
}