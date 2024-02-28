namespace DecoratorPattern
{
    /// <summary>
    /// Concrete decorator class for adding Orion to a pizza.
    /// </summary>
    internal class OrionDecorator : PizzaDecorator
    {
        public OrionDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal Price()
        {
            return base.Price() + 2.10M;
        }

        public override string Optionals()
        {
            return base.Optionals() + "\r\n Extra Orion";
        }
    }
}
