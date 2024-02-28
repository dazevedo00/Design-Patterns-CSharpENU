namespace FactoryPattern
{
    // This abstract class defines the structure for a Pizza Factory using the Factory Method Pattern.
    // It declares a method for creating pizzas, relying on subclasses to implement the creation logic.
    internal abstract class PizzaFactoryMethod
    {
        // Factory method to create a pizza based on the given pizzaType.
        // It delegates the creation to the concrete subclass by calling the MakePizza method.
        public Pizza CreatePizza(string pizzaType)
        {
            return MakePizza(pizzaType);
        }

        // Abstract method to be implemented by concrete subclasses.
        // It defines the creation logic for a specific type of pizza.
        protected abstract Pizza MakePizza(string pizzaType);
    }
}
