using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace _7_KatanaNancyFX
{
    public class DefaultModule : NancyModule
    {
        public DefaultModule()
        {
            Get["/"] = _ => "Hello World From Nancy!";
        }
    }
}
