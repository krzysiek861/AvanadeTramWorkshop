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
        private const string TRAM_SPEED = "Speed";
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
            var values = await ProcessEvents(events, log);
            var average = values.Select(x => int.Parse(x)).Sum() / values.Count;

            await signalRMessages.AddAsync(SignalRMessageHelper.CreateMessage(TRAM_SPEED, average.ToString()));
        }

        [FunctionName("AverageEngineTemperature")]
        public static async Task AverageEngineTemperature(
            [EventHubTrigger("engine-temperature-hub", Connection = "EventHubConnectionString")] EventData[] events, ILogger log,
            [SignalR(HubName = "serverless")] IAsyncCollector<SignalRMessage> signalRMessages)
        {
            var values = await ProcessEvents(events, log);
            var average = values.Select(x => int.Parse(x)).Sum() / values.Count;

            await signalRMessages.AddAsync(SignalRMessageHelper.CreateMessage(TRAM_ENGINE_TEMPERATURE, average.ToString()));
        }

        [FunctionName("MaxTramWeight")]
        public static async Task MaxTramWeight(
            [EventHubTrigger("tram-weight-hub", Connection = "EventHubConnectionString")] EventData[] events, ILogger log,
            [SignalR(HubName = "serverless")] IAsyncCollector<SignalRMessage> signalRMessages)
        {
            var values = await ProcessEvents(events, log);
            var max = values.Select(x => int.Parse(x)).Max();

            await signalRMessages.AddAsync(SignalRMessageHelper.CreateMessage(TRAM_WEIGHT, max.ToString()));
        }

        private static async Task<List<string>> ProcessEvents(EventData[] events, ILogger log)
        {
            var exceptions = new List<Exception>();
            var values = new List<string>();

            foreach (var eventData in events)
            {
                try
                {
                    // Replace these two lines with your processing logic.
                    log.LogInformation($"{DateTime.UtcNow} - C# Event Hub trigger function processed a message: {eventData.EventBody}");
                    values.Add(eventData.EventBody.ToString());
                    await Task.Yield();
                }
                catch (Exception e)
                {
                    // We need to keep processing the rest of the batch - capture this exception and continue.
                    // Also, consider capturing details of the message that failed processing so it can be processed again later.
                    exceptions.Add(e);
                }
            }

            // Once processing of the batch is complete, if any messages in the batch failed processing throw an exception so that there is a record of the failure.
            if (exceptions.Count > 1)
            {
                throw new AggregateException(exceptions);
            }

            if (exceptions.Count == 1)
            {
                throw exceptions.Single();
            }

            return values;
        }
    }
}
