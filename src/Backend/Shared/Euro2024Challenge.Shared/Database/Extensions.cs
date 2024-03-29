﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Euro2024Challenge.Shared.Database
{
    public static class Extensions
    {
        public static IServiceCollection AddSqlServer<T>(this IServiceCollection services) where T : DbContext
        {
            services.ConfigureOptions<DatabaseOptions>();
            services.AddDbContext<T>((serviceProvider, option) =>
            {
                var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;
                option.UseSqlServer(databaseOptions.ConnectionString, sqlOption =>
                {
                    sqlOption.EnableRetryOnFailure(databaseOptions.MaxRetryCount);
                    sqlOption.CommandTimeout(databaseOptions.CommandTimeout);

                });
            });

            return services;
        }
    }
}
