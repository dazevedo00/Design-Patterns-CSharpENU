namespace ObserverPattern
{
    internal class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new();
        private readonly string Product;
        private readonly int Price;
        private string Status;

        public ConcreteSubject(string product, int price, string status)
        {
            Product = product;  
            Price = price;
            Status = status;
        }

        internal string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string status)
        {
            this.Status = status;
            Console.WriteLine($"The status changed to {status}");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            Console.WriteLine($"Notify all observers");
            observers.ForEach(o => o.UpdateObservers(Status));
        }

        public void RegistObserver(IObserver observer)
        {
            Console.WriteLine($"Add Observer");

            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
