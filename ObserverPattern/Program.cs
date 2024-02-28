// Notes:
// This code snippet demonstrates the Observer Pattern in action.
// A ConcreteSubject, representing an iPhone with an initial status of "No Stock," is created.
// Three ConcreteObservers (user1, user2, and user3) are registered to observe changes in the iPhone's status.
// The current status is displayed, and the user is prompted to press any key to change the status to "In Stock."
// Upon changing the status, all registered observers are notified, and their updated status is displayed.
// The Observer Pattern enables a one-to-many dependency between objects, so that when one object changes state,
// all its dependents are notified and updated automatically.
using ObserverPattern;

//Create subject
ConcreteSubject iphone = new("IPhone 11", 4900, "No Stock");
Console.WriteLine("Actual status:" + iphone.GetStatus());

//Create Observer
ConcretObserver user1 = new("User1", iphone);
ConcretObserver user2 = new("User2", iphone);
ConcretObserver user3 = new("User3", iphone);

Console.WriteLine("Press any key to change status");

Console.ReadKey();

iphone.SetStatus("In Stock");
Console.Read();
