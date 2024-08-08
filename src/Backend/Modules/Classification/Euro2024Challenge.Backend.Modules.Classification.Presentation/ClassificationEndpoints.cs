using Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.CreatePlayerClassification;
using Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;
using Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetPlayerClassifications;
using MediatR;
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
        
        classifications.MapPost("", CreatePlayerClassification)
            .Produces(200);
    }
    
    private static async Task<IReadOnlyCollection<GetClassificationsResponse>> GetClassifications([FromServices] ISender sender)
    {
        var result = await sender.Send(new GetClassificationsQuery());

        return result;
    }
    
    private static async Task<GetPlayerClassificationsResponse> GetPlayerClassifications([FromServices] ISender sender, Guid playerId)
    {
        var result = await sender.Send(new GetPlayerClassificationsQuery(playerId));

        return result;
    }
    
    private static async Task<IResult> CreatePlayerClassification([FromServices] ISender sender, CreatePlayerClassificationRequest request)
    {
        await sender.Send(new CreatePlayerClassificationCommand(request.PlayerId, request.BetId, request.Points));
        
        return Results.Ok("Get for player");
    }
}