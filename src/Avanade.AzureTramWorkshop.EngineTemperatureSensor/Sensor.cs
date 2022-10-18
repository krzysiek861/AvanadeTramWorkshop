using Avanade.AzureTramWorkshop.Common;

namespace Avanade.AzureTramWorkshop.EngineTemperatureSensor
{
    internal class Sensor : ISensor
    {
        // number of events to be sent to the event hub
        private const int numOfEvents = 10;

        private const string configName = "EngineTemperatureSensor";

        private readonly ConfigurationReader<Configuration> configurationReader = new();

        public string EventHubName { get; } = "engine-temperature-hub";

        public async Task<IEnumerable<string>> GenerateValues()
        {
            var random = new Random();
            var configuration = await configurationReader.GetConfiguration(configName);

            await Task.Delay(2 * 1000);

            if (configuration != null)
            {
                var values = Enumerable.Range(1, numOfEvents)
                   .Select(n => random.Next(configuration.Min, configuration.Max).ToString())
                   .ToList();

                return values;
            }

            return Enumerable.Empty<string>();
        }
    }
}
