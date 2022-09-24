using Newtonsoft.Json;

namespace Avanade.AzureTramWorkshop.Common
{
    public class SignalRMessageData
    {
        [JsonRequired]
        [JsonProperty("sensor_name")]
        public string? Name { get; set; }

        [JsonRequired]
        [JsonProperty("sensor_value")]
        public string? Value { get; set; }
    }
}
