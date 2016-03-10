using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CLHelloServer;

namespace WcfHelloWorld
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        private static readonly IHelloWorld HelloWorld = new HelloWorld();
        public string SayHello()
        {
            return HelloWorld.SayHello();
        }
    }
}
