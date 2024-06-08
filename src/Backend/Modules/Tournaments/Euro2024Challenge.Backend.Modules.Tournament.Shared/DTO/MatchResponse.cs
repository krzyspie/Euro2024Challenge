namespace Euro2024Challenge.Backend.Modules.Tournament.Shared.DTO;

public sealed record MatchResponse(
    int Id,
    int Number,
    int GuestTeamId,
    int AwayTeamId,
    int GuestTeamGoals,
    int AwayTeamGoals,
    DateTime StartHour);
    