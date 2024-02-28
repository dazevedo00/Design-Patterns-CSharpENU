// Notes:
// This code snippet demonstrates the use of Azure Service Bus in a Minimal API application.
// Ensure you have the Azure.Messaging.ServiceBus NuGet package installed.
//
// Configuration:
// - The configurations are not placed in a separate file for simplicity in this example.
// - Replace "Insert Connection String" with your Service Bus namespace connection string.
// - Replace "Insert Queue Name" with the name of your Service Bus queue.
//
// Instructions:
// - Run the application and observe the processing of messages from the specified Service Bus queue.
// - Press any key to end the processing and stop receiving messages.

using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using SBReceiver;

// Minimal API, the configurations are not being placed in a separate file.
// connection string to your Service Bus namespace
string connectionString = "Insert Connection String";

// name of your Service Bus queue
string queueName = "Insert Queue Name";

Console.WriteLine("Hello, World!");
await Task.Run(async () => await GetQueueAsync(connectionString, queueName));
Console.WriteLine("Press any key to end the application");
Console.ReadKey();

List<Person> Persons = new();

//----------------------------------------------------------------------------------------------------------------------------
//------------------------------------          CODE         -----------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------
static async Task GetQueueAsync(string connectionString, string queueName)
{
    // The Service Bus client types are safe to cache and use as a singleton for the lifetime
    // of the application, which is best practice when messages are being published or read
    // regularly.

    ServiceBusClient client = new(connectionString); // the client that owns the connection and can be used to create senders and receivers

    // create a processor that we can use to process the messages
    // the processor that reads and processes messages from the queue
    ServiceBusProcessor processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions());

    try
    {
        // add handler to process messages
        processor.ProcessMessageAsync += MessageHandler;

        // add handler to process any errors
        processor.ProcessErrorAsync += ErrorHandler;

        // start processing 
        await processor.StartProcessingAsync();

        Console.WriteLine("Wait for a minute and then press any key to end the processing");
        Console.ReadKey();

        // stop processing 
        Console.WriteLine("\nStopping the receiver...");
        await processor.StopProcessingAsync();
        Console.WriteLine("Stopped receiving messages");
    }
    finally
    {
        // Calling DisposeAsync on client types is required to ensure that network
        // resources and other unmanaged objects are properly cleaned up.
        await processor.DisposeAsync();
        await client.DisposeAsync();
    }
}

static async Task MessageHandler(ProcessMessageEventArgs args)
{
    string body = args.Message.Body.ToString();
    Console.WriteLine($"Received: {body}");

    Person person = JsonConvert.DeserializeObject<Person>(body);

    if(person != null)
    {
        List<Person> persons = new List<Person> { person };
    }

    // complete the message. message is deleted from the queue. 
    await args.CompleteMessageAsync(args.Message);
}

// handle any errors when receiving messages
static Task ErrorHandler(ProcessErrorEventArgs args)
{
    Console.WriteLine(args.Exception.ToString());
    return Task.CompletedTask;
}