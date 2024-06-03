using Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create;
using Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get;
using Euro2024Challenge.Backend.Modules.Players.Application.Bets.Update;
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

            playerBets.MapGet("/{playerId}", GetPlayerBets)
                .Produces(200);

            playerBets.MapPost("/match-bet", CreateMatchBet)
                .Produces(201);

            playerBets.MapPost("/top-scorer", CreateTopScorerBet)
                .Produces(201);

            playerBets.MapPost("/tournament-winner", CreateTournamentWinnerBet)
                .Produces(201);
            
            playerBets.MapPut("/match-bet", UpdateMatchBet)
                .Produces(201);

            playerBets.MapPut("/top-scorer", UpdateTopScorerBet)
                .Produces(201);

            playerBets.MapPut("/tournament-winner", UpdateTournamentWinnerBet)
                .Produces(201);


        }

        private static async Task<IResult> CreateMatchBet([FromServices] ISender sender, CreateMatchBetRequest request)
        {
            await sender.Send(new CreateMatchBetCommand(request.PlayerId, request.MatchId, request.Winner, request.HomeTeamGoals, request.AwayTeamGoals));

            return Results.Ok();
        }

        private static async Task<IResult> CreateTopScorerBet([FromServices] ISender sender, CreateTopScorerBetRequest request)
        {
            await sender.Send(new CreateTopScorerBetCommand(request.PlayerId, request.FootballerId, request.Goals));

            return Results.Ok();
        }

        private static async Task<IResult> CreateTournamentWinnerBet([FromServices] ISender sender, CreateTournamentWinnerBetRequest request)
        {
            await sender.Send(new CreateTournamentWinnerBetCommand(request.PlayerId, request.TeamId));

            return Results.Ok();
        }

        private static async Task<IResult> UpdateMatchBet([FromServices] ISender sender, UpdateMatchBetRequest request)
        {
            await sender.Send(new UpdateMatchBetCommand(request.PlayerId, request.MatchId, request.Winner, request.HomeTeamGoals, request.AwayTeamGoals));

            return Results.Ok();
        }

        private static async Task<IResult> UpdateTopScorerBet([FromServices] ISender sender, UpdateTopScorerBetRequest request)
        {
            await sender.Send(new UpdateTopScorerBetCommand(request.PlayerId, request.FootballerId, request.Goals));

            return Results.Ok();
        }

        private static async Task<IResult> UpdateTournamentWinnerBet([FromServices] ISender sender, UpdateTournamentWinnerBetRequest request)
        {
            await sender.Send(new UpdateTournamentWinnerBetCommand(request.PlayerId, request.TeamId));

            return Results.Ok();
        }
        private static async Task<IResult> GetPlayerBets([FromServices] ISender sender, Guid playerId)
        {
            await sender.Send(new GetPlayerBetsQuery(playerId));

            return Results.Ok();
        }
    }
}
