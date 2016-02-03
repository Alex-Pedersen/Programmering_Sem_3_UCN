using System;
using System.Linq;

namespace Sem_Program_01
{
    public class Program
    {
        private int[] _arrayintInts;

        private static void Main(string[] args)
        {
            var program = new Program {_arrayintInts = new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}};
            Console.WriteLine(program._arrayintInts);

            var sum = program.SumOfArray();
            Console.WriteLine("Total amount of the array is : " + sum);

            Console.Write("Enter the number you want to search for : ");
            var varnumber = Console.Read();
            Console.WriteLine("Amount of numbers in array with the number : " + program.ArraySearch(varnumber));

            Console.WriteLine("\n\nPress any key to close program");
            Console.ReadKey();
        }

        private int SumOfArray()
        {
            return _arrayintInts.Sum();
        }

        private int AverageOfArray()
        {
            return (int) _arrayintInts.Average();
        }

        private int ArraySearch(int searchVar)
        {
            var totalNumbersVar = 0;
            foreach (var VARIABLE in _arrayintInts)
            {
                if (VARIABLE == searchVar)
                {
                    totalNumbersVar++;
                }
            }

            return totalNumbersVar;
        }
    }
}