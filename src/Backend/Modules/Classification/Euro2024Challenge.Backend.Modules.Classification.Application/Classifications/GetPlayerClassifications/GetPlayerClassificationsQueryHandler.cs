using MediatR;

namespace Euro2024Challenge.Backend.Modules.Classification.Application.Classifications.GetPlayerClassifications;

public class GetPlayerClassificationsQueryHandler : IRequestHandler<GetPlayerClassificationsQuery, GetPlayerClassificationsResponse>
{
    public GetPlayerClassificationsQueryHandler()
    {
    }

    public Task<GetPlayerClassificationsResponse> Handle(GetPlayerClassificationsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


