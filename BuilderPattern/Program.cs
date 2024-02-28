// Notes:
// This code snippet demonstrates the application of the Builder Pattern in a pizzeria context.
// Two pizzas, PizzaCalabreza and PizzaMozzarela, are constructed using their respective builders within the Pizzaria class.
// The Pizzaria class encapsulates the pizza creation process, providing flexibility in crafting different types of pizzas.
// After each pizza is created, its content is retrieved and displayed using the PizzaContent method.
// The Builder Pattern simplifies the construction of diverse pizza configurations while maintaining clean and readable client code.
using BuilderPattern;

var pizzaria = new Pizzaria(new PizzaCalabreza());
pizzaria.CreatePizza();
var pizza1 = pizzaria.GetPizza();
pizza1.PizzaContent();

pizzaria = new Pizzaria(new PizzaMozzarela());
pizzaria.CreatePizza();
var pizza2 = pizzaria.GetPizza();
pizza2.PizzaContent();