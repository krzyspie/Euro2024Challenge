﻿using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands
{
    public sealed record GetPlayerBetsCommand(Guid PlayerId) : IRequest<Unit>;
}
