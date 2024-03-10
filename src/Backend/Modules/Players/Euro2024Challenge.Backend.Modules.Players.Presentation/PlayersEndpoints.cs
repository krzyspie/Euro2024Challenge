using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MediatR;

using Euro2024Challenge.Backend.Modules.Players.Application.Players.Create;
using Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands;

namespace Euro2024Challenge.Backend.Modules.Players.Presentation
{
    public static class PlayersEndpoints
    {
        public static void MapPlayersEndpoints(this IEndpointRouteBuilder app)
        {
            var players = app.MapGroup("players-module/players");

            players.MapPost("", () => CreatePlayer)
                .Produces(201);
        }

        private static async Task<IResult> CreatePlayer(ISender sender, CreatePlayerRequest createPlayerRequest)
        {
            await sender.Send(new CreatePlayerCommand(createPlayerRequest.Email, createPlayerRequest.Username));

            return Results.Ok();
        }
    }
}
