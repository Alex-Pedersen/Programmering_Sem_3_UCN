using System;
using Sem_Program_05.Interfaces;

namespace Sem_Program_05.Classes
{
    class Optimist : IObserver
    {
        public void NotifyMe(int amount)
        {
            var stringvar = "\nThere is some left, happyface. Amount : " + amount;
            Console.WriteLine(stringvar);
        }
    }
}
