using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Tournament.Shared;

public record class MatchUpdated(int MatchId, int HomeTeamGoals, int AwayTeamGoals) : IEvent;
