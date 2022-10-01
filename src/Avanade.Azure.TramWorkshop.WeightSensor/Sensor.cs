using Avanade.AzureTramWorkshop.Common;

namespace Avanade.AzureTramWorkshop.WeightSensor
{
    internal class Sensor : ISensor
    {
        private const int numOfEvents = 25;

        private const string configName = "WeightSensor";

        private readonly ConfigurationReader<Configuration> configurationReader = new();

        public string EventHubName { get; } = "tram-weight-hub";

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
