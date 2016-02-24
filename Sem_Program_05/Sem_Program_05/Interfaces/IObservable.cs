using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Program_05.Interfaces
{
    interface IObservable
    {
        void NotifyAll();

        void Add();

        void Remove();
    }
}
