namespace FactoryPattern
{
    internal class PizzaFactoryB : PizzaFactoryMethod
    {
        protected override Pizza MakePizza(string type)
        {
            return type.ToUpper() switch
            {
                "M" => new PizzaMozzarelaB(),
                "C" => new PizzaCalabressaB(),
                _ => throw new ArgumentException("Invalid pizza type"),
            };
        }
    }
}