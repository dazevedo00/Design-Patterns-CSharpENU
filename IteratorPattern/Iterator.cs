namespace IteratorPattern
{
    internal class Iterator : IAbstractIterator
    {
        private int current = 0;
        private int step = 1;
        private ConcreteCollection _collection;

        public Iterator(ConcreteCollection collection)
        {
            this._collection = collection;
        }

        public Client First()
        {
            current = 0;
            return _collection.GetClient(current);
        }
        
        public Client Next()
        {
            current += step;
            return IsDone ? null : _collection.GetClient(current);
        }

        public bool IsDone
        {
            get { return current >= _collection.Count(); }
        }
    }
}
