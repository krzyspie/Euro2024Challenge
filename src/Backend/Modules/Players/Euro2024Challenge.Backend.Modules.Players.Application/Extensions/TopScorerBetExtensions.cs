using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class TopScorerBetExtensions
{
    public static PlayerTopScorerBetDto ToPlayerTopScorerBetDto(this TopScorerBet bet)
    {
        return new PlayerTopScorerBetDto
        {
            FootballerId = bet.FootballerId,
            Goals = bet.Goals
        };
    }
}