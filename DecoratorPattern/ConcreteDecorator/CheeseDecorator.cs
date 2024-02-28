namespace DecoratorPattern
{
    /// <summary>
    /// Concrete decorator class for adding Cheese to a pizza.
    /// </summary>
    internal class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal Price()
        {
            return base.Price() + 5.03M;
        }

        public override string Optionals()
        {
            return base.Optionals() + "\r\n Extra Cheese";
        }
    }
}
