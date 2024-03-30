using Microsoft.Extensions.DependencyInjection;

using Euro2024Challenge.Backend.Modules.Turnaments.Core;
using Euro2024Challenge.Backend.Modules.Turnaments.Presentation;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Api
{
    public static class RegisterModule
    {
        public static IServiceCollection RegisterPlayersModule(this IServiceCollection services)
        {
             services
                .AddCore()
                .AddPresentation();

            return services;
        }
    }
}
