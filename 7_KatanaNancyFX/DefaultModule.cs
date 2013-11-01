using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace KatanaNancyFX
{
    /// <summary>
    /// A NancyModule is analagous to an ASP.NET controller. It's used by Nancy to bundle applications
    /// </summary>
    public class DefaultModule : NancyModule
    {
        public DefaultModule()
        {
            // Looking at the simple code example above, we've created a simple constructor for CarModule and we've created a simple 
            // route to the base. The _ is simply a variable name that by convention means we don't care about it, which we don't because
            // immediately to the right of our lambda expression we completely ignore it and simply return 'Hello World'. The _ could of 
            // equally be named parameters or any other variable name.
            Get["/"] = _ => "Hello World From Nancy!";

            // NOTE: So what is the 'Get'? well it's how Nancy does routing (which I personally find a little easier than Asp.Net MVC). 
            // It's a property on the NancyModule base class that takes in our example a string that is the path eg /status we can treat 
            // as a key and our value is a Func that is passed a dynamic parameter and returns a dynamic type. So in our example we call 
            // the dynamic parameters _ and we return a string "Hello World" as a dynamic. More info on C# Func:  http://bit.ly/5aOpdN+
            // It might look a bit weird but you get used to it and it's not really that magical.

            // This means Nancy uses Func<dynamic, dynamic> to assign and invoke a delegate via a lambda expression.

            // The encapsulated method must correspond to the method signature that is defined by this delegate. This means that the encapsulated 
            // method must have one (dynamic) parameter that is passed to it by value, and that it must return a (dynamic) value.

            Get["/sneaky"] = _ => { return MySneakyMethod(); };

            // We see we've created a route that matches the path /car/123 we've used similar tokenization for the id to that in traditional MVC. 
            // The {name} denote a parameter and Nancy works it's magic and puts all the values on a dynamic dictionary which this time we call 
            // parameters (last time it was _ ). Since it's a dynamic dictionary we can simply access the parameters.id property and then cast it to an int.
            Get["/something/{id}"] = parameters =>
            {
                int id = parameters.id;
                return Negotiate.WithStatusCode(HttpStatusCode.OK).WithModel(id);
            };
        }

        private string MySneakyMethod()
        {
            return "Hello Sneaky World!";
        }
    }
}
