using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Class1
    {
        public static int SumOfArray(int[] _arrayintInts)
        {
            return _arrayintInts.Sum();
        }

        public static int AverageOfArray(int[] _arrayintInts)
        {
            return (int)_arrayintInts.Average();
        }

        public static int ArraySearch(int[] _arrayintInts, int searchVar)
        {
            return _arrayintInts.Count(variable => variable == searchVar);
        }

        public static bool checkerMethod(int[] _arrayintInts)
        {
            var checker = _arrayintInts.Contains(3);
            return checker;
        }
    }
}
