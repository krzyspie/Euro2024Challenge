namespace Euro2024Challenge.Backend.Modules.Tournaments.Core.DTO;

public sealed record AddFootballerRequest(string Name, int TeamId, int Goals);