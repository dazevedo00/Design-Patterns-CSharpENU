namespace IteratorPattern
{
    internal interface IAbstractIterator
    {
        Client First();
        Client Next();
        bool IsDone { get; }
    }
}
