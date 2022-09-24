using Avanade.AzureTramWorkshop.Common;
using Azure.Messaging.EventHubs;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanade.AzureTramWorkshop.Functions
{
    public static class EventProcessor
    {
        private const string TRAM_SPEED_TAG = "Speed";
        private const string TRAM_ENGINE_TEMPERATURE = "Temperature";
        private const string TRAM_WEIGHT = "Weight";

        [FunctionName("negotiate")]
        public static SignalRConnectionInfo Negotiate(
            [HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest req,
            [SignalRConnectionInfo(HubName = "serverless")] SignalRConnectionInfo connectionInfo)
        {
            return connectionInfo;
        }

        [FunctionName("AverageTramSpeed")]
        public static async Task AverageSpeed(
            [EventHubTrigger("tram-speed-hub", Connection = "EventHubConnectionString")] EventData[] events, ILogger log,
            [SignalR(HubName = "serverless")] IAsyncCollector<SignalRMessage> signalRMessages)
        {
            var exceptions = new List<Exception>();
            var values = new List<int>();

            foreach (EventData eventData in events)
            {
                try
                {
                    // Replace these two lines with your processing logic.
                    log.LogInformation($"{DateTime.UtcNow} - C# Event Hub trigger function processed a message: {eventData.EventBody}");
                    values.Add(int.Parse(eventData.EventBody.ToString()));
                    await Task.Yield();
                }
                catch (Exception e)
                {
                    // We need to keep processing the rest of the batch - capture this exception and continue.
                    // Also, consider capturing details of the message that failed processing so it can be processed again later.
                    exceptions.Add(e);
                }
            }

            var average = values.Sum() / values.Count;
            // Once processing of the batch is complete, if any messages in the batch failed processing throw an exception so that there is a record of the failure.

            if (exceptions.Count > 1)
                throw new AggregateException(exceptions);

            if (exceptions.Count == 1)
                throw exceptions.Single();

            await signalRMessages.AddAsync(SignalRMessageHelper.CreateMessage(TRAM_SPEED_TAG, average.ToString()));
        }
    }
}
