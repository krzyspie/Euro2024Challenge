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

    public static List<GetClassificationsResponse> ToGetClassificationsResponse(this IEnumerable<Domain.Entities.PlayerBetPoints> betPoints, IDictionary<Guid, string> playersUsernames)
    {
        IEnumerable<IGrouping<string, int>> playerBetPointsSum = betPoints.GroupBy(p => p.PlayerId, p => p.Points);

        List<GetClassificationsResponse> result = [];

        foreach (var item in playerBetPointsSum)
        {
            string userName = string.Empty;
            var id = Guid.Parse(item.Key);
            playersUsernames.TryGetValue(id, out userName);
            result.Add(new GetClassificationsResponse 
            { 
                PlayerId = id,
                PlayerUsername = userName,
                Points = item.Sum() 
            });
        }
        
        return result;
    }

}
