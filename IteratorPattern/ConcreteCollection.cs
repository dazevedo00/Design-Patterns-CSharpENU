namespace IteratorPattern
{
    internal class ConcreteCollection : IAbstractCollection
    {
        List<Client> _list = new List<Client>();

        public Client GetClient(int Index)
        {
            return _list[Index];
        }

        public void AddClient(Client Client)
        {
            _list.Add(Client);
        }

        public int Count()
        {
            return _list.Count;
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
