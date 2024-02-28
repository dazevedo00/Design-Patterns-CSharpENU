namespace BuilderPattern
{
    internal class PizzaMozzarela : PizzaBuilder
    {
        internal override void AddIngredient()
        {
            pizza.Dough = DoughType.Extra1;
            pizza.Edge = EdgeType.Type2;
            pizza.Size = Size.Medium;
        }

        internal override void MakePizza()
        {
            pizza.Ingredients = new List<string> { "Ingredient 444", "Ingredient 222 " };
        }
    }
}
