namespace DecoratorPattern
{
    /// <summary>
    /// Concrete implementation of the IPizza interface representing a basic pizza.
    /// </summary>
    internal class Pizza : IPizza
    {
        /// <summary>
        /// Gets the optional toppings for the normal pizza.
        /// </summary>
        /// <returns>A string representing the optional toppings.</returns>
        public string Optionals()
        {
            return "Normal Pizza";
        }

        /// <summary>
        /// Gets the price of the normal pizza.
        /// </summary>
        /// <returns>The price of the normal pizza.</returns>
        public decimal Price()
        {
            return 10.00M;
        }
    }
}
