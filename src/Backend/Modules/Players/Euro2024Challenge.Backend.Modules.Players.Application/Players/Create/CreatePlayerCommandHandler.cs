using Euro2024Challenge.Backend.Modules.Players.Application.Players.Commands;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Players.Create
{
    internal sealed class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Unit>
    {
        public Task<Unit> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
