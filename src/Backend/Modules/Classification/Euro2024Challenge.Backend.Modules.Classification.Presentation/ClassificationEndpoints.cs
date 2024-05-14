using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
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
    
    private static Task<IResult> GetClassifications()
    {
        return Task.FromResult(Results.Ok());
    }
    
    private static Task<IResult> GetPlayerClassifications(Guid playerId)
    {
        return Task.FromResult(Results.Ok());
    }
}