using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace KatanaSignalRSelfHosted
{
    public class MyHub : Hub    
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}
