using System;
using System.Linq;

namespace Functions
{
    public static class Class1
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

        public static bool CheckerMethod(int[] _arrayintInts)
        {
            var checker = _arrayintInts.Contains(3);
            return checker;
        }

        public static string ReturnArray(int[] _arrayintInts)
        {
            var Array = "";
            foreach (var VARIABLE in _arrayintInts)
            {
                Array += " " + VARIABLE;
            }
            return Array;
        }
    }
}
