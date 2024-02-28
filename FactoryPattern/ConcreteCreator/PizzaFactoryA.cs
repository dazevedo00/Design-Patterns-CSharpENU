namespace FactoryPattern
{
    internal class PizzaFactoryA : PizzaFactoryMethod
    {
        protected override Pizza MakePizza(string type)
        {
            return type.ToUpper() switch
            {
                "M" => new PizzaMozzarelaA(),
                "C" => new PizzaCalabressaA(),
                _ => throw new ArgumentException("Invalid pizza type"),
            };
        }
    }
}
