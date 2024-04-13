namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

public record MatchResponse(
    int Id,
    int Number,
    int GuestTeamId,
    int AwayTeamId,
    int GuestTeamGoals,
    int AwayTeamGoals,
    DateTime StartHour);
    