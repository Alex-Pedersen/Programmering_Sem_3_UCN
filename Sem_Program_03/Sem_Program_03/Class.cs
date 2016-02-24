using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Program_03.Abstract;

namespace Sem_Program_03
{
    class Class
    {
        static void Main(string[] args)
        {
            TestMethod(ACity, APerson);

        }

        public static ACity ACity { get; set; }

        public static APerson APerson { get; set; }

        private static void TestMethod(ACity acity, APerson person)
        {
            var variablePerson = person.CreatePerson("fName", "lName", "Adress", 60559952, 260995, true, false);
            var variableCity = acity.CreateCity("Navn", "Location", 5, variablePerson);
            acity.printCity(variableCity);
        }
    }
}
