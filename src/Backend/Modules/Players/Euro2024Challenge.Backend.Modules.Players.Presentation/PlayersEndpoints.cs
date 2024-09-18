using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MediatR;

using Euro2024Challenge.Backend.Modules.Players.Application.Players.Create;
using Euro2024Challenge.Backend.Modules.Players.Application.Players.Get;
using Microsoft.AspNetCore.Mvc;

namespace Euro2024Challenge.Backend.Modules.Players.Presentation;

public static class PlayersEndpoints
{
    public static void MapPlayersEndpoints(this IEndpointRouteBuilder app)
    {
        var players = app.MapGroup("players-module/players");

        players.MapPost("", CreatePlayer)
            .Produces(201);
        
        players.MapGet("/{playerId:guid}", GetPlayer)
            .Produces(200);
    }

    private static async Task<IResult> CreatePlayer([FromServices] ISender sender, CreatePlayerRequest request)
    {
        await sender.Send(new CreatePlayerCommand(request.Email, request.Username));

        return Results.Ok();
    }
    
    private static async Task<IResult> GetPlayer([FromServices] ISender sender, Guid playerId)
    {
        var player = await sender.Send(new GetPlayerQuery(playerId));

        return Results.Ok(player);
    }

    private static async Task<IResult> GetAllPlayers([FromServices] ISender sender)
    {
        var players = await sender.Send(new GetPlayersQuery());

        return Results.Ok(players);
    }
}