using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Euro2024Challenge.Shared.Database
{
    internal class DatabaseOptionsSetup : IConfigureOptions<DatabaseOptions>
    {
        private const string ConfigurationSectionName = "DatabaseOptions";
        private readonly IConfiguration _configuration;

        public DatabaseOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(DatabaseOptions options)
        {
            string connectionString = _configuration.GetConnectionString("DbConnection");

            options.ConnectionString = connectionString;

            _configuration.GetSection(ConfigurationSectionName).Bind(options);
        }
    }
}
