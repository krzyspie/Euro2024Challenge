﻿namespace Euro2024Challenge.Backend.Modules.Players.Application.Bets.Create
{
    public sealed record CreateTournamentWinnerBetRequest(Guid PlayerId, int TeamId);
}
