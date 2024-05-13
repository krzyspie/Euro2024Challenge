namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;

public class ClassificationDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string CollectionName { get; set; } = null!;
}