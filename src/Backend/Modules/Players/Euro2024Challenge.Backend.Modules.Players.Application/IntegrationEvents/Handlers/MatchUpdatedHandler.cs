using Euro2024Challenge.Backend.Modules.Tournament.Shared;
using Euro2024Challenge.Shared;

namespace Euro2024Challenge.Backend.Modules.Players.Application;

public class MatchUpdatedHandler : IEventHandler<MatchUpdated>
{
    public Task HandleAsync(MatchUpdated integrationEvent, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("MatchUpdatedHandler");

        return Task.CompletedTask;
    }
}
