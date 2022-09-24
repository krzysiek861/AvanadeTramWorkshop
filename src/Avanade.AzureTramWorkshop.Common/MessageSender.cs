using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using System.Text;

namespace Avanade.AzureTramWorkshop.Common
{
    public class MessageSender<TSensor> where TSensor : ISensor
    {
        // connection string to the Event Hubs namespace
        private const string connectionString = "";

        // name of the event hub
        private const string eventHubName = "tram-speed-hub";

        // The Event Hubs client types are safe to cache and use as a singleton for the lifetime
        // of the application, which is best practice when events are being published or read regularly.
        static readonly EventHubProducerClient producerClient = new(connectionString, eventHubName);

        private readonly TSensor sensor;

        public MessageSender(TSensor sensor)
        {
            this.sensor = sensor;
        }

        public async Task Run()
        {
            // Create a batch of events 
            using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();

            var sensorValues = await sensor.GenerateValues();

            foreach (var sensorValue in sensorValues)
            {
                if (!eventBatch.TryAdd(new EventData(Encoding.UTF8.GetBytes(sensorValue))))
                {
                    // if it is too large for the batch
                    throw new Exception($"{DateTime.UtcNow} - Event '{sensorValue}' is too large for the batch and cannot be sent.");
                }
            }

            try
            {
                // Use the producer client to send the batch of events to the event hub
                await producerClient.SendAsync(eventBatch);
                Console.WriteLine($"{DateTime.UtcNow} - A batch of {sensorValues.Count()} events has been published.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await producerClient.DisposeAsync();
            }
        }
    }
}