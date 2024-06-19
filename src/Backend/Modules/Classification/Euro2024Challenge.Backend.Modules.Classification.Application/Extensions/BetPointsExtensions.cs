namespace Euro2024Challenge.Backend.Modules.Classification.Application;

public static class BetPointsExtensions
{
    public static GetPlayerClassificationsResponse ToGetPlayerClassificationsResponse(this IEnumerable<Domain.Entities.BetPoints> betPoints, Guid playerId)
    {
        return new GetPlayerClassificationsResponse()
        {
            PlayerId = playerId,
            BetsPoints = betPoints
                        .Select(x => new BetPointsDto(){ BetId = x.BetId, Points = x.Points })
                        .ToList()
                        .AsReadOnly()
        };
    }

}
