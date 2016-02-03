using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Program_01
{
    class Program
    {
        public int[] arrayintInts;

        static void Main(string[] args)
        {
            var program = new Program { arrayintInts = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 } };
            var sum = program.SumOfArrays();
            Console.WriteLine("Total amount of the array is : " + sum);

        }

        private int SumOfArrays()
        {
            return arrayintInts.Sum();
        }
    }
}
