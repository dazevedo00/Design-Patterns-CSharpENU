// Notes:
// This code snippet demonstrates the use of the Decorator Pattern in a pizza ordering system.
// The 'Pizza' class represents a basic pizza, and various decorators (BaconDecorator, CheeseDecorator, OrionDecorator)
// are used to add extra toppings and calculate the total price accordingly.
// The initial pizza details and price are displayed, and then a series of decorators are applied to showcase
// how the pizza's optional toppings and total price are modified with each decorator.
// Pressing Enter allows for easy observation of the decorated pizza's characteristics.
using DecoratorPattern;

IPizza ipizza = new Pizza();

Console.WriteLine(ipizza.Optionals());
Console.WriteLine($"Price: {ipizza.Price()}");

Console.WriteLine("Press some key to decorator");
Console.ReadLine();

IPizza ipizza2 = new Pizza();
IPizza baconDecorator = new BaconDecorator(ipizza2);
IPizza cheeseDecorator = new CheeseDecorator(baconDecorator);
IPizza orionDecorator = new OrionDecorator(cheeseDecorator);

Console.WriteLine(orionDecorator.Optionals());
Console.WriteLine($"Total Price: {orionDecorator.Price()}");
Console.ReadLine();