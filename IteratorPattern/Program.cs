// Notes:
// This code snippet exemplifies the Iterator Pattern.
// A ConcreteCollection is created to hold a collection of clients.
// Clients are added to the collection, and an Iterator is created to encapsulate the iteration process.
// The iterator is used to traverse the collection, and client details (Id and Name) are displayed using a for loop.
// The Iterator Pattern provides a way to access elements of a collection sequentially without exposing its underlying representation.
using IteratorPattern;

// Create the collection
ConcreteCollection collection = new();
collection.AddClient(new Client(10, "Pedro"));
collection.AddClient(new Client(11, "José"));
collection.AddClient(new Client(12, "Helder"));
collection.AddClient(new Client(13, "Daniel"));
collection.AddClient(new Client(14, "Andreia"));

// Encapsulate the iteration
Iterator iterator = collection.CreateIterator();

Console.WriteLine("Using iterator");

for (Client client = iterator.First(); !iterator.IsDone; client = iterator.Next())
{
    Console.WriteLine($"Id:{client.Id} Name:{client.Name}");
}
Console.Read();

