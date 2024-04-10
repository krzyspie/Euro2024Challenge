using Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;
using Euro2024Challenge.Backend.Modules.Tournaments.Core.Entities;
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
            await matchService.GetByNumber(number);

            return Results.Ok();
        }
        
        private static async Task<IResult> GetTeam([FromServices] ITeamService teamService, int id)
        {
            await teamService.Get(id);

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
