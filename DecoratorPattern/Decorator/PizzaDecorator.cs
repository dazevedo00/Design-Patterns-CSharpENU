namespace DecoratorPattern
{
    /// <summary>
    /// Base class for pizza decorators. Implements the IPizza interface to provide a common structure.
    /// </summary>
    internal class PizzaDecorator : IPizza
    {
        // Reference to the decorated pizza
        private readonly IPizza _pizza;

        /// <summary>
        /// Constructor to initialize the decorated pizza.
        /// </summary>
        /// <param name="pizza">The pizza to be decorated.</param>
        public PizzaDecorator(IPizza pizza)
        {
            this._pizza = pizza;
        }

        /// <summary>
        /// Gets the optional toppings for the decorated pizza.
        /// </summary>
        /// <returns>A string representing the optional toppings.</returns>
        public virtual string Optionals()
        {
            // Delegates to the decorated pizza to get its options
            return _pizza.Optionals();
        }

        /// <summary>
        /// Gets the total price of the decorated pizza.
        /// </summary>
        /// <returns>The total price of the decorated pizza.</returns>
        public virtual decimal Price()
        {
            // Delegates to the decorated pizza to get its price
            return _pizza.Price();
        }
    }
}
