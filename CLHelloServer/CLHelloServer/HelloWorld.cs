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
            return "Hello World";
        }

        public string ReturnResponse(string input)
        {
            System.Threading.Thread.Sleep(5000);
            return input;
        }
    }
}
