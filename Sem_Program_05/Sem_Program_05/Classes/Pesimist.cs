using System;
using Sem_Program_05.Interfaces;

namespace Sem_Program_05.Classes
{
    class Pesimist : IObserver
    {
        public void NotifyMe(int amount)
        {
            var stringvar = "\nThere is almost nothing left, sadface. Amount : " + amount;
            Console.WriteLine(stringvar);
        }
    }
}
