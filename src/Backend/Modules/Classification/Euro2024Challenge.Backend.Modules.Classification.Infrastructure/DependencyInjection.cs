using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Repositories;
using Euro2024Challenge.Backend.Modules.Classification.Infrastructure.Database.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace Euro2024Challenge.Backend.Modules.Classification.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.ConfigureOptions<ClassificationDatabaseSettingsSetup>();
        services.AddSingleton<IClassificationRepository, PlayersClassificationRepository>();
        return services;
    }
}