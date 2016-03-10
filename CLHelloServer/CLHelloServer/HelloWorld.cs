using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHelloServer
{
    public class HelloWorld : IHelloWorld
    {
        public string SayHello()
        {
            return "Hello Remote World";
        }
    }
}
