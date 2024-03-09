using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands
{
    internal sealed record CreatePlayerCommand(string Email, string Username) : IRequest<Unit>;
}
