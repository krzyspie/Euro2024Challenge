using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Euro2024Challenge.Backend.Modules.Classification.Presentation;

public static class ClassificationEndpoints
{
    public static void MapClassificationEndpoints(this IEndpointRouteBuilder app)
    {
        var classifications = app.MapGroup("classifications-module/classifications");
        
        classifications.MapGet("", GetClassifications)
            .Produces(200);
        
        classifications.MapGet("{playerId:guid}", GetPlayerClassifications)
            .Produces(200);
    }
    
    private static async Task<IResult> GetClassifications([FromServices] IClassificationRepository repo)
    {
        var result = await repo.GetAll();
        return Results.Ok(result.FirstOrDefault());
    }
    
    private static Task<IResult> GetPlayerClassifications(Guid playerId)
    {
        return Task.FromResult(Results.Ok("Get for player"));
    }
}