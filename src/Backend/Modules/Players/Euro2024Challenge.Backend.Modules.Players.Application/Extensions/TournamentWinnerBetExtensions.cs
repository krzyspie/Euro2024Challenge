using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class TournamentWinnerBetExtensions
{
    private static PlayerTournamentWinnerBetDto ToTournamentWinnerBetDto(this TournamentWinnerBet bet)
    {
        return new PlayerTournamentWinnerBetDto
        {
            TeamId = bet.TeamId
        };
    }
}