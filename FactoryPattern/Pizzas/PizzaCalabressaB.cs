namespace FactoryPattern
{
    internal class PizzaCalabressaB : Pizza
    {
        public PizzaCalabressaB()
        {
            Name = "Pizza Calabressa B";
            Dough = "Extra Dough";
            Sauce = "No Sauce";
            Ingredients.Add("Cheese");
            Ingredients.Add("Extra Oreg");
        }
    }
}
