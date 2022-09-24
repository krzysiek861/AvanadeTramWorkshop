using Avanade.AzureTramWorkshop.Common;

namespace Avanade.AzureTramWorkshop.SpeedSensor
{
    internal class Sensor : ISensor
    {
        // number of events to be sent to the event hub
        private const int numOfEvents = 25;

        public async Task<IEnumerable<string>> GenerateValues()
        {
            var random = new Random();
            var values = Enumerable.Range(1, numOfEvents)
                       .Select(n => random.Next(30, 50).ToString())
                       .ToList();

            await Task.Delay(2 * 1000);

            return values;
        }
    }
}
