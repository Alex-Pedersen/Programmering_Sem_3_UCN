using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class StringCalculator
    {
        private const int DefaultValue = 0;

        public int AddString(String numbers)
        {
            return DefaultValue;
        }
    }

    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void AddReturnZeroWhenStringEmpty()
        {
            var calculator = new StringCalculator();
            var res = calculator.AddString("");

            Assert.AreEqual(0,res);
        }
    }
}
