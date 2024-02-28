namespace BuilderPattern
{
    internal abstract class PizzaBuilder
    {
        protected Pizza pizza;

        internal void CreatePizza()
        {
            pizza = new Pizza();
        }

        internal Pizza GetPizza()
        {
            return pizza;
        }

        internal abstract void MakePizza();
        internal abstract void AddIngredient();
    }
}
