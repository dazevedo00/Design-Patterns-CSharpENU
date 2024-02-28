namespace IteratorPattern
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
