using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;

public class ClassificationDatabaseSettingsSetup : IConfigureOptions<ClassificationDatabaseSettings>
{
    private const string ConfigurationSectionName = "ClassificationDatabase";
    private readonly IConfiguration _configuration;

    public ClassificationDatabaseSettingsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void Configure(ClassificationDatabaseSettings options)
    {
        string connectionString = _configuration.GetConnectionString("ConnectionString")!;

        options.ConnectionString = connectionString;

        _configuration.GetSection(ConfigurationSectionName).Bind(options);
    }
}