namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

public sealed record AddMatchRequest(int Number, int GuestTeamId, int AwayTeamId);