using Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetClassifications;
using Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetPlayerClassifications;
using Euro2024Challenge.Backend.Modules.Classification.Application.Dto;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Extensions;

public static class PlayerBetPointsxtensions
{
    public static GetPlayerClassificationsResponse ToGetPlayerClassificationsResponse(this IEnumerable<Domain.Entities.PlayerBetPoints> betPoints, Guid playerId)
    {
        return new GetPlayerClassificationsResponse()
        {
            PlayerId = playerId,
            BetsPoints = betPoints
                        .Select(x => new BetPointsDto() { BetId = Guid.Parse(x.BetId), Points = x.Points })
                        .ToList()
                        .AsReadOnly()
        };
    }

    public static GetClassificationsResponse ToGetClassificationsResponse(this IEnumerable<Domain.Entities.PlayerBetPoints> betPoints)
    {
        IEnumerable<IGrouping<string, Domain.Entities.PlayerBetPoints>> enumerable = betPoints.GroupBy(p => p.PlayerId);


        return null;
    }

}
