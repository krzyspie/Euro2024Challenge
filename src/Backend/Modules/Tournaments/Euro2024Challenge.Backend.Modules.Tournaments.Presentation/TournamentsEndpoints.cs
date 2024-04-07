using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

using Microsoft.AspNetCore.Mvc;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Presentation
{
    public static class TournamentsEndpoints
    {
        public static void MapTournamentsEndpoints(this IEndpointRouteBuilder app)
        {
            var players = app.MapGroup("tournaments-module/");
        }
    }
}
