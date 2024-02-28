namespace DecoratorPattern
{
    /// <summary>
    /// Interface defining the contract for a pizza.
    /// </summary>
    internal interface IPizza
    {
        /// <summary>
        /// Gets the optional toppings for the pizza.
        /// </summary>
        /// <returns>A string representing the optional toppings.</returns>
        string Optionals();

        /// <summary>
        /// Gets the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>
        decimal Price();
    }
}
