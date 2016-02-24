namespace Sem_Program_05.Interfaces
{
    interface IObservable
    {
        void NotifyAll();

        void Add(IObserver observer);

        void Remove(IObserver observer);
    }
}
