namespace FactoryPattern
{
    internal class PizzaMozzarelaA : Pizza
    {
        public PizzaMozzarelaA()
        {
            Name = "Pizza Mozzarela A";
            Dough = "Low Dough";
            Sauce = "Extra Sauce";
            Ingredients.Add("Extra cheese");
            Ingredients.Add("Extra Onion");
        }
    }
}
