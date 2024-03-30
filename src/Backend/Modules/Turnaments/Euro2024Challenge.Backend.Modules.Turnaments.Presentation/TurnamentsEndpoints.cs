using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

using Microsoft.AspNetCore.Mvc;

namespace Euro2024Challenge.Backend.Modules.Turnaments.Presentation
{
    public static class TurnamentsEndpoints
    {
        public static void MapTurnamentsEndpoints(this IEndpointRouteBuilder app)
        {
            var players = app.MapGroup("turnaments-module/");
        }
    }
}
