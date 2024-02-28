namespace FactoryPattern
{
    internal class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod? CreatePizzeria(string local)
        {
            return local switch
            {
                "A" => new PizzaFactoryA(),
                "B" => new PizzaFactoryB(),
                _ => null,
            };
        }
    }
}
