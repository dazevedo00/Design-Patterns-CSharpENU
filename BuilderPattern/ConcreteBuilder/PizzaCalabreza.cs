namespace BuilderPattern
{
    internal class PizzaCalabreza : PizzaBuilder
    {
        internal override void AddIngredient()
        {
            pizza.Dough = DoughType.Extra2;
            pizza.Edge = EdgeType.Type3;
            pizza.Size = Size.Large;
        }

        internal override void MakePizza()
        {
            pizza.Ingredients = new List<string> { "Ingredient 1", "Ingredient 2 "};
        }
    }
}
