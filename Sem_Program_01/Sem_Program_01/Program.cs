using System;
using System.Linq;
using Functions;

namespace Sem_Program_01
{
    public class Program
    {
        private int[] _arrayintInts;

        private static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            if (args.Length == 0) throw new ArgumentException("Argument is empty collection", nameof(args));

            var program = new Program {_arrayintInts = new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}};
            Console.WriteLine(program._arrayintInts);

            var sum = Class1.SumOfArray(program._arrayintInts);
            Console.WriteLine("Total amount of the array is : " + sum);

            Console.Write("Enter the number you want to search for : ");
            var varnumber = Console.Read();
            Console.WriteLine("Amount of numbers in array with the number : " + Class1.ArraySearch(program._arrayintInts, varnumber));

            Console.WriteLine("The array has the number 3 : " + Class1.checkerMethod(program._arrayintInts));

            Console.WriteLine("\n\nPress any key to close program");
            Console.ReadKey();
        }

        
    }
}