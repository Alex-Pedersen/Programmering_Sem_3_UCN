using System;
using System.Linq;
using Functions;

namespace Sem_Program_01
{
    public class Program
    {
        private int[] _arrayintInts;

        private static void Main(String[] args)
        {
            var program = new Program {_arrayintInts = new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}};
            Console.WriteLine("Array right now: " + Class1.ReturnArray(program._arrayintInts) + "\n");

            Console.WriteLine("\nTotal amount of the array is : " + Class1.SumOfArray(program._arrayintInts));

            Console.WriteLine("\nAverage of array : " + Class1.AverageOfArray(program._arrayintInts));

            Console.Write("\nEnter the number you want to search for : ");
            var varnumber = Console.Read();
            Console.WriteLine("\nAmount of numbers in array with the number : " + Class1.ArraySearch(program._arrayintInts, varnumber));

            Console.WriteLine("\nThe array has the number 3 : " + Class1.CheckerMethod(program._arrayintInts));

            Console.WriteLine("\n\nPress any key to close program");
            Console.ReadKey();
        }

        
    }
}