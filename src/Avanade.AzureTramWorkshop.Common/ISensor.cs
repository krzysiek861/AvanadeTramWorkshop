namespace Avanade.AzureTramWorkshop.Common
{
    public interface ISensor
    {
        string EventHubName { get; }
        public Task<IEnumerable<string>> GenerateValues();
    }
}
