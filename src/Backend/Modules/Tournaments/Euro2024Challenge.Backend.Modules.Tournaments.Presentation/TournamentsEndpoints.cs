using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Extensions;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Presentation
{
    public static class TournamentsEndpoints
    {
        public static void MapTournamentsEndpoints(this IEndpointRouteBuilder app)
        {
            var tournaments = app.MapGroup("tournaments-module/");

            tournaments.MapPost("match", AddMatch)
                .Produces(201);
            
            tournaments.MapPut("match", UpdateMatchResult)
                .Produces(200);
            
            tournaments.MapGet("match", GetMatch)
                .Produces(200);
        }
        
        private static async Task<IResult> AddMatch([FromServices] IMatchService matchService, AddMatchRequest request)
        {
            await matchService.Add(new Match());

            return Results.Ok();
        }
        
        private static async Task<IResult> UpdateMatchResult([FromServices] IMatchService matchService, UpdateMatchResultRequest request)
        {
            await matchService.UpdateResult(request.Number, request.GuestTeamGoals, request.AwayTeamGoals);

            return Results.Ok();
        }
        
        private static async Task<IResult> GetAllMatches([FromServices] IMatchService matchService)
        {
            await matchService.GetAll();

            return Results.Ok();
        }
        
        private static async Task<IResult> GetMatch([FromServices] IMatchService matchService, int number)
        {
            Match? match = await matchService.GetByNumber(number);

            return Results.Ok(match.ToMatchResponse());
        }
        
        private static async Task<IResult> GetTeam([FromServices] ITeamService teamService, IEnumerable<int> ids)
        {
            await teamService.GetTeamsAsync(ids.ToList());

            return Results.Ok();
        }
        
        private static async Task<IResult> GetFootballer([FromServices] IFootballerService footballerService, int id)
        {
            await footballerService.Get(id);

            return Results.Ok();
        }
        
        private static async Task<IResult> UpdateFootballerGoals([FromServices] IFootballerService footballerService, int id, UpdateFootballerGoalsRequest request)
        {
            await footballerService.UpdateGoals(id, request.Goals);

            return Results.Ok();
        }
    }
}
