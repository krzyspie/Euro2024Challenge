using System.Threading.Channels;

namespace Euro2024Challenge.Shared;

public class InMemoryMessageQueue
{
    private readonly Channel<IEvent> _channel =
        Channel.CreateUnbounded<IEvent>();

    public ChannelReader<IEvent> Reader => _channel.Reader;

    public ChannelWriter<IEvent> Writer => _channel.Writer;
}
