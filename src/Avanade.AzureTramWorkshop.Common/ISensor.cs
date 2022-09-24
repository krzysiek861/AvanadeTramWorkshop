namespace Avanade.AzureTramWorkshop.Common
{
    public interface ISensor
    {
        public Task<IEnumerable<string>> GenerateValues();
    }
}
