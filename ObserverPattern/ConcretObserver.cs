namespace ObserverPattern
{
    internal class ConcretObserver : IObserver
    {
        public string User { get; set; }

        public ConcretObserver(string name, ISubject subject)
        {
            User = name;
            subject.RegistObserver(this);
        }

        public void UpdateObservers(string status)
        {
            Console.WriteLine($"Hi {User}, the product status has been changed to {status}");
        }
    }
}
