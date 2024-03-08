
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;

namespace Euro2024Challenge.Backend.Modules.Players.Presentation
{
    public static class PlayersEndpoints
    {
        public static void MapPlayersEndpoints(this IEndpointRouteBuilder app)
        {
            var players = app.MapGroup("players-module/players");

            players.MapPost("", () => "Created")
                .Produces(201);
        }
    }
}
