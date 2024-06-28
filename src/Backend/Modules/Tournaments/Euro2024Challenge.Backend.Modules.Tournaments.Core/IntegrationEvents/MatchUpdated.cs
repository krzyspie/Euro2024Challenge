using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Tournaments.Core;

public record MatchUpdated(int MatchId, int HomeTeamGoals, int AwayTeamGoals) : IEvent;
