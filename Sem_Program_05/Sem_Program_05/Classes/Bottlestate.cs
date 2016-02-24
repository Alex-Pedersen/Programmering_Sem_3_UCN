using System.Collections.Generic;
using Sem_Program_05.Interfaces;

namespace Sem_Program_05.Classes
{
    class Bottlestate : IObservable
    {
        private int Amount { get; set; }

        private List<IObserver> _list = new List<IObserver>();

        public Bottlestate(int amount)
        {
            Amount = amount;
        }

        public void ChangeAmount(int amount)
        {
            Amount = amount;
            NotifyAll();
        }

        public void NotifyAll()
        {
            while (true)
            {
                foreach (var variable in _list)
                {
                    variable.NotifyMe(Amount);
                }
                break;
            }
        }

        public void Add(IObserver observer)
        {
            _list.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _list.Remove(observer);
        }
    }
}