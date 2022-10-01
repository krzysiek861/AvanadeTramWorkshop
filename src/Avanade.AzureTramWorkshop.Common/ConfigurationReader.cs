using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace Avanade.AzureTramWorkshop.Common
{
    public class ConfigurationReader<TConfiguration> where TConfiguration : class
    {
        // connection string to the App Configuration.
        private const string connectionString = "";

        private readonly IConfigurationRoot configurationRoot;

        private IConfigurationRefresher? refresher;

        public ConfigurationReader()
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(connectionString);

            configurationRoot = builder.Build();
        }

        public ConfigurationReader(string key)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(options => {
                options.Connect(connectionString)
                        .ConfigureRefresh(refresh => {
                            refresh.Register(key)
                                   .SetCacheExpiration(TimeSpan.FromSeconds(10));
                        });

                refresher = options.GetRefresher();
            });

            configurationRoot = builder.Build();
        }

        public async Task<TConfiguration?> GetConfiguration(string key)
        {
            try
            {
                if (refresher != null)
                {
                    await refresher.TryRefreshAsync();
                }
                
                var configuration = configurationRoot.GetSection(key).Get<TConfiguration>();

                return configuration;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
