using Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Euro2024Challenge.Backend.Modules.Players.Presentation
{
    public static class PlayerBetsEndpoints
    {
        public static void MapPlayerBetsEndpoints(this IEndpointRouteBuilder app)
        {
            var playerBets = app.MapGroup("players-module/player-bets");

            playerBets.MapPost("/match-bet", CreateMatchBet)
                .Produces(201);

            playerBets.MapPost("/top-scorer", CreateTopScorerBet)
                .Produces(201);

            playerBets.MapPost("/turnament-winner", CreateTurnamentWinnerBet)
                .Produces(201);
        }

        private static async Task<IResult> CreateMatchBet([FromServices] ISender sender, CreateMatchBetRequest request)
        {
            await sender.Send(new CreateMatchBetCommand(request.PlayerId, request.MatchId, request.Result, request.HomeTeamGoals, request.AwayTeamGoals));

            return Results.Ok();
        }

        private static async Task<IResult> CreateTopScorerBet([FromServices] ISender sender, CreateTopScorerBetRequest request)
        {
            await sender.Send(new CreateTopScorerBetCommand(request.PlayerId, request.FootballerId, request.Goals));

            return Results.Ok();
        }

        private static async Task<IResult> CreateTurnamentWinnerBet([FromServices] ISender sender, CreateTurnamentWinnerBetRequest request)
        {
            await sender.Send(new CreateTurnamentWinnerBetCommand(request.PlayerId, request.TeamId));

            return Results.Ok();
        }
    }
}
