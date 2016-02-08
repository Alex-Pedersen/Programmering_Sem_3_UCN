using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name\n");
            String fName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            String lName = Console.ReadLine();
            Customer customer = new Customer(fName, lName);
            
            Console.WriteLine("The customer is called : " + customer.printCustomer(customer));

        }
    }
}
