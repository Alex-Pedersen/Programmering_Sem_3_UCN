using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem_Program_03.Classes;
using Sem_Program_03.Interface;

namespace Sem_Program_03.Abstract
{
    abstract class APerson : IPerson
    {
        public Person CreatePerson(string fName, string lName, string adress, int tlfNumber, int cprNumber, bool married, bool employed)
        {
            return new Person(fName, lName, adress, tlfNumber, cprNumber, married, employed);
        }

        public Person ReadPerson(int tlfNumber, int cprNumber)
        {
            throw new NotImplementedException();
        }

        public void Update(string fName, string lName, string adress, int tlfNumber, int cprNumber, bool married, bool employed)
        {
            throw new NotImplementedException();
        }

        public void Delete(int tlfNumber, int cprNumber)
        {
            throw new NotImplementedException();
        }
    }
}
