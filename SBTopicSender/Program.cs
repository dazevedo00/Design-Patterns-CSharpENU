// Notes:
// This code snippet demonstrates how to use Azure Service Bus in a Minimal API application.
// Ensure you have the Azure.Messaging.ServiceBus NuGet package installed.
//
// Configuration:
// - The configurations are not placed in a separate file for simplicity in this example.
// - Replace "Insert Connection String" with your Service Bus namespace connection string.
// - Replace "Insert Topic Name" with the name of your Service Bus topic.
// - Replace "Insert Subscription Name" with the name of your subscription to the topic.
//
// Instructions:
// - Run the application and observe the publishing of messages to the specified topic.
// - Press any key to end the application.
using Azure.Messaging.ServiceBus;

// Minimal API, the configurations are not being placed in a separate file.
// connection string to your Service Bus namespace
string connectionString = "Insert Connection String";

// name of your Service Bus queue
string topicName = "Insert Topic Name";

// name of the subscription to the topic
string subscriptionName = "Insert Subscription Name";

Console.WriteLine("Hello, World!");
Task.Run(async () => await SendQueueAsync(connectionString, topicName, subscriptionName));
Console.WriteLine("Press any key to end the application");
Console.ReadKey();

static async Task SendQueueAsync(string connectionString, string topicName, string subscriptionName)
{
    int numOfMessages = 3;

    // The Service Bus client types are safe to cache and use as a singleton for the lifetime
    // of the application, which is best practice when messages are being published or read
    // regularly.
    //
    // Create the clients that we'll use for sending and processing messages.
    var client = new ServiceBusClient(connectionString);
    var sender = client.CreateSender(topicName);

    // create a batch 
    using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

    for (int i = 1; i <= numOfMessages; i++)
    {
        // try adding a message to the batch
        if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
        {
            // if it is too large for the batch
            throw new Exception($"The message {i} is too large to fit in the batch.");
        }
    }

    try
    {
        // Use the producer client to send the batch of messages to the Service Bus topic
        await sender.SendMessagesAsync(messageBatch);
        Console.WriteLine($"A batch of {numOfMessages} messages has been published to the topic.");
    }
    finally
    {
        // Calling DisposeAsync on client types is required to ensure that network
        // resources and other unmanaged objects are properly cleaned up.
        await sender.DisposeAsync();
        await client.DisposeAsync();
    }

    Console.WriteLine("Press any key to end the application");
    Console.ReadKey();

}
