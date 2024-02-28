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
// - Run the application and observe the publishing of messages to the specified Service Bus queue.
// - Press any key to end the application.
using Azure.Messaging.ServiceBus;

// Minimal API, the configurations are not being placed in a separate file.
// connection string to your Service Bus namespace
string connectionString = "Insert Connection String";

// name of your Service Bus queue
string queueName = "Insert Queue Name";

ServiceBusClient client = new(connectionString); // the client that owns the connection and can be used to create senders and receivers

//Only for demo data
SBSender.Data.FillData();

Console.WriteLine("Hello, World!");
await Task.Run(async () => await SendQueueAsync(connectionString, queueName, client));
Console.WriteLine("Press any key to end the application");
Console.ReadKey();

//----------------------------------------------------------------------------------------------------------------------------
//------------------------------------          CODE         -----------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------

static async Task SendQueueAsync(string connectionString, string queueName, ServiceBusClient client)
{
    // The Service Bus client types are safe to cache and use as a singleton for the lifetime
    // of the application, which is best practice when messages are being published or read
    // regularly.

    // Create the clients that we'll use for sending and processing messages.
    ServiceBusSender sender = client.CreateSender(queueName);

    // create a batch 
    using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
    {
        //Example Message of all persons
        SBSender.Data.Persons.ForEach(p =>
        {
            string message = SBSender.Data.ConvertPersonToJson(p);
            if (!messageBatch.TryAddMessage(new ServiceBusMessage($"{message}")))
            {
                // if it is too large for the batch
                throw new Exception($"The message {message} is too large to fit in the batch.");
            }
        });

        try
        {
            // Use the producer client to send the batch of messages to the Service Bus queue
            await sender.SendMessagesAsync(messageBatch);
            Console.WriteLine($"A batch of {SBSender.Data.Persons.Count} messages has been published to the queue.");
        }
        finally
        {
            // Calling DisposeAsync on client types is required to ensure that network
            // resources and other unmanaged objects are properly cleaned up.
            await sender.DisposeAsync();
            await client.DisposeAsync();
        }
    }
}
