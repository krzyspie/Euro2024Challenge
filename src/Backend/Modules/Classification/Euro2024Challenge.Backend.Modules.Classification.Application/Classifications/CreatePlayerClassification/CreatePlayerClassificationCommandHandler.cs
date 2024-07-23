﻿using Euro2024Challenge.Backend.Modules.Classification.Domain.Entities;
using Euro2024Challenge.Backend.Modules.Classification.Domain.Repositories;
using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.CreatePlayerClassification;

public class CreatePlayerClassificationCommandHandler : IRequestHandler<CreatePlayerClassificationCommand, Unit>
{
    readonly IClassificationRepository _classificationRepository;
    public CreatePlayerClassificationCommandHandler(IClassificationRepository classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }

    public async Task<Unit> Handle(CreatePlayerClassificationCommand request, CancellationToken cancellationToken)
    {
        BetPoints betPoints = new()
        {
            BetId = request.BetId,
            Points = request.Points
        };

        await _classificationRepository.Insert(request.PlayerId, betPoints);

        return Unit.Value;
    }
}
