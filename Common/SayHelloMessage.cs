using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Class SayHelloMessage.
    /// </summary>
    public class SayHelloMessage
    {
    }

    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            Receive<SayHelloMessage>(greet => Console.WriteLine("Hello World"));
        }
    }
}
