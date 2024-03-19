using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Euro2024Challenge.Backend.Modules.Players.Presentation
{
    public static class PlayerBetsEndpoints
    {
        public static void MapPlayerBetsEndpoints(this IEndpointRouteBuilder app)
        {
            var playerBets = app.MapGroup("players-module/player-bets");
        }
    }
}
