namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

public sealed record UpdateMatchResultRequest(int Number, int GuestTeamGoals, int AwayTeamGoals);