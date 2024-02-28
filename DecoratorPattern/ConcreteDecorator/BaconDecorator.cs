namespace DecoratorPattern
{
    /// <summary>
    /// Concrete decorator class for adding Bacon to a pizza.
    /// </summary>
    internal class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal Price()
        {
            return base.Price() + 4.00M;
        }

        public override string Optionals()
        {
            return base.Optionals() + "\r\n Extra Bacon";
        }
    }
}
