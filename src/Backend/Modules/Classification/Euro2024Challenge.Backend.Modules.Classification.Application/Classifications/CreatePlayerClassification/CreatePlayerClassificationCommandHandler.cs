using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.CreatePlayerClassification;

public class CreatePlayerClassificationCommandHandler : IRequestHandler<CreatePlayerClassificationCommand, Unit>
{
    public Task<Unit> Handle(CreatePlayerClassificationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
