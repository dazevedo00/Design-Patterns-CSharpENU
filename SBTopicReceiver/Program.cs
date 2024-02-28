// Notes:
// This code snippet showcases the use of Azure Service Bus in a Minimal API application.
// Ensure you have the Azure.Messaging.ServiceBus NuGet package installed.
//
// Configuration:
// - The configurations are not placed in a separate file for simplicity in this example.
// - Replace "Insert Connection String" with your Service Bus namespace connection string.
// - Replace "Insert Topic Name" with the name of your Service Bus topic.
// - Replace "Insert Subscription Name" with the name of your subscription to the topic.
//
// Instructions:
// - Run the application and observe the processing of messages from the specified topic subscription.
// - Press any key to end the processing and stop receiving messages.
using Azure.Messaging.ServiceBus;

// Minimal API, the configurations are not being placed in a separate file.
// connection string to your Service Bus namespace
string connectionString = "Insert Connection String";

// name of your Service Bus queue
string topicName = "Insert Topic Name";

// name of the subscription to the topic
string subscriptionName = "Insert Subscription Name";

Console.WriteLine("Hello, World!");
await Task.Run(async () => await GetTopicAsync(connectionString, topicName, subscriptionName));
Console.WriteLine("Press any key to end the application");
Console.ReadKey();

static async Task GetTopicAsync(string connectionString, string topicName, string subscriptionName)
{
    // The Service Bus client types are safe to cache and use as a singleton for the lifetime
    // of the application, which is best practice when messages are being published or read
    // regularly.

    // Create the clients that we'll use for sending and processing messages.
    ServiceBusClient client = new(connectionString);

    // create a processor that we can use to process the messages
    ServiceBusProcessor processor = client.CreateProcessor(topicName, subscriptionName, new ServiceBusProcessorOptions());

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

// handle received messages
static async Task MessageHandler(ProcessMessageEventArgs args)
{
    string subscriptionName = "subscription1";
    string body = args.Message.Body.ToString();
    Console.WriteLine($"Received: {body} from subscription: {subscriptionName}");

    // complete the message. messages is deleted from the subscription. 
    await args.CompleteMessageAsync(args.Message);
}

// handle any errors when receiving messages
static Task ErrorHandler(ProcessErrorEventArgs args)
{
    Console.WriteLine(args.Exception.ToString());
    return Task.CompletedTask;
}




