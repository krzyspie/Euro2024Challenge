using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Euro2024Challenge.Shared.Database
{
    public static class Extensions
    {
        public static IServiceCollection AddPostgres<T>(this IServiceCollection services) where T : DbContext
        {
            services.ConfigureOptions<DatabaseOptionsSetup>();
            // using var serviceProvider = services.BuildServiceProvider();
            //var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;
            
             services.AddDbContext<T>((serviceProvider, option) =>
             {
                 var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;
                 option.UseNpgsql(databaseOptions.ConnectionString, sqlOption =>
                 {
                     sqlOption.EnableRetryOnFailure(databaseOptions.MaxRetryCount);
                     sqlOption.CommandTimeout(databaseOptions.CommandTimeout);
            
                 });
             });

            //using var serviceProvider = services.BuildServiceProvider();
            // var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            // var connectionString = configuration.GetConnectionString("DbConnection");
            //
            // services.AddDbContext<T>(options =>
            //     options.UseNpgsql(connectionString));

            return services;
        }
    }
}
