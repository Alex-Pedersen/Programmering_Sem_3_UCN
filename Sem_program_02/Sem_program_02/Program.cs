using System;
using System.Collections.Generic;

namespace Sem_Program_02
{
    static class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee("Jens", "System Programmer", 25000);
            Employee b = new Employee("Peter", "System Developer", 40000);
            Employee c = new Employee("Kurt", "Human Resource", 45000);
            Employee d = new Employee("Inga", "Programmer", 32000);
            Employee e = new Employee("Pavline", "Programmer", 34000);

            Project p1 = new Project("C#", 1);
            Project p2 = new Project("C++", 2);

            p1.AddEmployee(a, 150);
            p1.AddEmployee(b, 50);
            p1.AddEmployee(c, 250);
            p2.AddEmployee(a, 50);
            p2.AddEmployee(d, 350);
            p2.AddEmployee(e, 10);
            p2.AddEmployee(b, 400);

            Console.WriteLine("On the project " + p1.Name + " are the following employees working:");
            List<Employee> emps = p1.GetEmployees();
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("On the project " + p1.Name + " " + p1.GetTotalHours() + " hours used");
            Console.WriteLine("On the project " + p2.Name + " " + p2.GetTotalHours() + " hours used");
            Console.ReadLine();
        }
    }
}
