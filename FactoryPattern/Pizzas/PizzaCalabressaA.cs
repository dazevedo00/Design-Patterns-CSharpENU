namespace FactoryPattern
{
    internal class PizzaCalabressaA : Pizza
    {
        public PizzaCalabressaA()
        {
            Name = "Pizza Calabressa A";
            Dough = "Low Dough A";
            Sauce = "Extra Sauce A";
            Ingredients.Add("Extra cheese A");
            Ingredients.Add("Extra Onion A");
        }
    }
}
