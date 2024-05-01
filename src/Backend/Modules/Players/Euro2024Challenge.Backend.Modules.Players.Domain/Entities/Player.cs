using Euro2024Challenge.Backend.Modules.Players.Domain.ValueObjects;
using Euro2024Challenge.Shared.Domain;

namespace Euro2024Challenge.Backend.Modules.Players.Domain.Entities
{
    public sealed class Player : BaseEntity, IAggregateRoot
    {
        public required string Email { get; set; }
        public required string Username { get; set; }

        public TopScorerBet TopScorerBet { get; private set; } = null!;
        public TournamentWinnerBet TournamentWinnerBet { get; private set; } = null!;
        public ICollection<MatchBet> MatchBets { get; private set; } = new List<MatchBet>();

        public void ChangeTopScorerBet(int footballerId, int goals)
        {
            TopScorerBet = new TopScorerBet
            {
                PlayerId = Id,
                FootballerId = footballerId,
                Goals = goals
            };
        }
        
        public void ChangeTournamentWinnerBet(int teamId)
        {
            TournamentWinnerBet = new TournamentWinnerBet
            {
                PlayerId = Id,
                TeamId = teamId
            };
        }

        public void AddMatchBet(int matchId, ushort homeTeamGoals, ushort awayTeamGoals)
        {
            var matchBet = new MatchBet
            {
                PlayerId = Id,
                MatchId = matchId,
                Result = MatchResult.CreateNew(homeTeamGoals, awayTeamGoals)
            };
            
            MatchBets.Add(matchBet);
        }
        
        public void UpdateMatchBet(int matchId, ushort homeTeamGoals, ushort awayTeamGoals)
        {
            var bet = MatchBets.SingleOrDefault(x => x.MatchId == matchId);

            if (bet is null)
            {
                return;
            }

            MatchBets.Remove(bet);
            
            AddMatchBet(matchId, homeTeamGoals, awayTeamGoals);
        }
    }
}
