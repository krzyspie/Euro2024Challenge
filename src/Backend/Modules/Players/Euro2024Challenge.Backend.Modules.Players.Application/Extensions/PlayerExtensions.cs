using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class PlayerExtensions
{
    public static PlayerDto ToPlayerDto(this Player player)
    {
        return new PlayerDto
        {
            Id = player.Id,
            Username = player.Username,
            Email = player.Email
        };
    }
    
    public static PlayerBetsDto ToPlayerBetsDto(this Player player, TeamResponse tournamentWinnerTeam)
    {
        return new PlayerBetsDto
        {
            PlayerId = player.Id,
            TopScorerBet = player.TopScorerBet is null 
                ? null
                : new PlayerTopScorerBetDto
                {
                    //FootballerId = player.TopScorerBet.FootballerId,
                    Goals = player.TopScorerBet.Goals
                },
            TournamentWinner = player.TournamentWinnerBet is null
            ? null
            : new PlayerTournamentWinnerBetDto
            {
                TeamId = player.TournamentWinnerBet.TeamId,
                TeamName = tournamentWinnerTeam.Name
            },
            MatchBets = player.MatchBets is null 
                ? Enumerable.Empty<PlayerMatchBetDto>() 
                : player.MatchBets.ToPlayerMatchBetDto()
        };
    }
    
}