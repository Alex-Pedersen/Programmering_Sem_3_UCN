using System;
using System.Linq;

namespace Functions
{
    public static class Class1
    {
        public static int SumOfArray(int[] arrayintInts)
        {
            return arrayintInts.Sum();
        }

        public static int AverageOfArray(int[] arrayintInts)
        {
            return (int) arrayintInts.Average();
        }

        public static int ArraySearch(int[] arrayintInts, int searchVar)
        {
            return arrayintInts.Count(variable => variable == searchVar);
        }

        public static bool CheckerMethod(int[] arrayintInts, int searchVar)
        {
            var checker = arrayintInts.Contains(searchVar);
            return checker;
        }

        public static string ReturnArray(int[] arrayintInts)
        {
            return arrayintInts.Aggregate("", (current, variable) => string.Format("{0}{1}", current, (" " + variable)));
        }

        public static int ReadConsole()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
