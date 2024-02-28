namespace FactoryPattern
{
    internal class PizzaMozzarelaB : Pizza
    {
        public PizzaMozzarelaB()
        {
            Name = "Pizza Mozzarela B";
            Dough = "Hight Dough";
            Sauce = "Limon Sauce";
            Ingredients.Add("Extra Oregon");
            Ingredients.Add("Extra Tom");
        }
    }
}
