namespace ObserverPattern
{
    internal interface ISubject
    {
        void RegistObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
