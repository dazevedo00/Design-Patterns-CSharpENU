// Notes:
// This code snippet demonstrates the use of the Factory Method pattern in a console application representing a pizzeria.
//
// Functionality:
// - The user is prompted to select a local (A or B) and a pizza type (Margarita or Calzone).
// - The code then creates a specific pizzeria and pizza based on the user's choices using the Factory Method.
// - The details of the created pizza are displayed, and a success message is shown.
// - If an error occurs during the creation process, an error message is displayed.
// - The `GetValidInput` function ensures that user input is validated against the available options, promoting a user-friendly interface.
//
// Instructions:
// - Run the application, follow the prompts, and observe the creation and details of the chosen pizza.
// - Press any key to end the application.
using FactoryPattern;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("----------------Pizzeria--------------------");
Console.WriteLine("Select the local (A or B)");

var validLocals = new[] { "A", "B" };
var validPizzas = new[] { "M", "C" };

// Prompt the user for the local (A or B)
var choise = GetValidInput("Select the local (A or B): ", validLocals);

// Prompt the user for the Pizza (M or C)
var pizzaChoise = GetValidInput("Select the Pizza (M or C): ", validPizzas);

try
{
    // Create pizzeria based on user's choice
    PizzaFactoryMethod pizzeria = PizzaSimpleFactory.CreatePizzeria(choise);

    // Create pizza based on user's choice
    var pizza = pizzeria.CreatePizza(pizzaChoise);

    // Display the pizza details
    Console.WriteLine(pizza.MakePizza());
    Console.WriteLine("Pizza Done");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

static string GetValidInput(string prompt, string[] validOptions)
{
    string input;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine().ToUpper();
    } while (!validOptions.Contains(input));

    return input;
}

