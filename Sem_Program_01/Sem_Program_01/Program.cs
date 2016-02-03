using System;
using Functions;

namespace Sem_Program_01
{
    public class Program
    {
        private int[] _arrayintInts;

        private static void Main()
        {
            var program = new Program {_arrayintInts = new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}};
            Console.WriteLine("Array right now: {0}\n", Class1.ReturnArray(program._arrayintInts));

            Console.WriteLine("\nTotal amount of the array is : {0}", Class1.SumOfArray(program._arrayintInts));

            Console.WriteLine("\nAverage of array : {0}", Class1.AverageOfArray(program._arrayintInts));

            Console.WriteLine("\nEnter the number you want to search for : \n");

            Console.WriteLine("\nAmount of numbers in array with the number : " + Class1.ArraySearch(program._arrayintInts, Class1.ReadConsole()));

            Console.WriteLine("\nEnter the number you want to search for : \n");
           
            Console.WriteLine("\nEnter a number to see if it's in the Array : {0}\n", Class1.CheckerMethod(program._arrayintInts, Class1.ReadConsole()));

            Console.WriteLine("\n\nPress any key to close program");
            Class1.ReadConsole();
        }
    }
}