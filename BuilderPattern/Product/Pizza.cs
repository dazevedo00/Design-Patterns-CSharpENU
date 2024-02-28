namespace BuilderPattern
{
    internal class Pizza
    {
        public DoughType Dough { get; set; }
        public EdgeType Edge { get; set; }
        public Size Size { get; set; }

        public List<string> Ingredients { get; set; }

        public void PizzaContent()
        {
            Console.WriteLine($"Pizza Dough: {Dough}");
            Console.WriteLine($"Pizza Edge: {Edge}");
            Console.WriteLine($"Pizza Size: {Size}");
            Ingredients.ForEach( x => Console.WriteLine( x ) );
            Console.WriteLine("");
        }
    }
}
