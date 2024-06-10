using Euro2024Challenge.Backend.Modules.Players.Application.Bets.DTO;
using Euro2024Challenge.Backend.Modules.Players.Application.Extensions;
using Euro2024Challenge.Backend.Modules.Players.Domain.Repositories;
using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Get
{
    internal sealed class GetPlayerBetsQueryHandler(IPlayersRepository playersRepository, ITournamentModuleApi tournamentModuleApi) : IRequestHandler<GetPlayerBetsQuery, PlayerBetsDto>
    {
        private readonly IPlayersRepository _playersRepository = playersRepository;
        private readonly ITournamentModuleApi _tournamentModuleApi = tournamentModuleApi;

        public async Task<PlayerBetsDto> Handle(GetPlayerBetsQuery request, CancellationToken cancellationToken)
        {
            var result = await _playersRepository.GetWithBets(request.PlayerId);
            
            var team = result.TournamentWinnerBet is null ? null : await _tournamentModuleApi.GetTeam(result.TournamentWinnerBet.TeamId);
            var match = await _tournamentModuleApi.GetMatches(result.MatchBets.Select(m => m.MatchId).ToArray());
            var footballer = result.TopScorerBet is null ? null : await _tournamentModuleApi.GetFootballer(result.TopScorerBet.FootballerId);

            return result.ToPlayerBetsDto(team, footballer);
        }
    }
}
