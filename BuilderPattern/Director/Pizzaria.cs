namespace BuilderPattern
{
    internal class Pizzaria
    {
        private readonly PizzaBuilder _builder;

        public Pizzaria(PizzaBuilder builder)
        {
            _builder = builder;
        }

        //Construct
        public void CreatePizza()
        {
            _builder.CreatePizza();
            _builder.MakePizza();
            _builder.AddIngredient();
        }

        public Pizza GetPizza()
        {
            return _builder.GetPizza();
        }
    }
}
