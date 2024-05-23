using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
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
                .Produces(200);
            tournaments.MapPut("match/{number:int}", UpdateMatchResult)
                .Produces(200);
            tournaments.MapGet("match/{number:int}", GetMatch)
                .Produces(200);
            tournaments.MapGet("matches", GetAllMatches)
                .Produces(200);
            
            tournaments.MapGet("teams/{ids}", GetTeams)
                .Produces(200);
            
            tournaments.MapPut("footballer/{id:int}", UpdateFootballerGoals)
                .Produces(200);
            tournaments.MapGet("footballer/{id:int}", GetFootballer)
                .Produces(200);
        }
        
        private static async Task<IResult> AddMatch([FromServices] IMatchService matchService, AddMatchRequest request)
        {
            await matchService.Add(request);

            return Results.Ok();
        }
        
        private static async Task<IResult> UpdateMatchResult([FromServices] IMatchService matchService, int number, UpdateMatchResultRequest request)
        {
            await matchService.UpdateResult(number, request.GuestTeamGoals, request.AwayTeamGoals);

            return Results.Ok();
        }
        
        private static async Task<IResult> GetAllMatches([FromServices] IMatchService matchService)
        {
            var matches = await matchService.GetAll();

            return Results.Ok(matches);
        }
        
        private static async Task<IResult> GetMatch([FromServices] IMatchService matchService, int number)
        {
            var match = await matchService.GetByNumber(number);

            return Results.Ok(match);
        }
        
        private static async Task<IResult> GetTeams([FromServices] ITeamService teamService, int[] ids)
        {
            var teams = await teamService.GetTeamsAsync(ids.ToList());

            return Results.Ok(teams);
        }
        
        private static async Task<IResult> GetFootballer([FromServices] IFootballerService footballerService, int id)
        {
            var result = await footballerService.Get(id);

            return result is null ? Results.NotFound() : Results.Ok(result);
        }
        
        private static async Task<IResult> UpdateFootballerGoals([FromServices] IFootballerService footballerService,
             int id, [FromBody] UpdateFootballerGoalsRequest request)
        {
            await footballerService.UpdateGoals(id, request.Goals);

            return Results.Ok();
        }
    }
}
