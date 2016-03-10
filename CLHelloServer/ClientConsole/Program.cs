using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    public class Program
    {
        private static readonly IHelloService.IHelloService HelloService = new IHelloService.HelloServiceClient();
        static void Main(string[] args)
        {
            Console.WriteLine(HelloService.SayHello());
            Console.ReadLine();
        }
    }
}
