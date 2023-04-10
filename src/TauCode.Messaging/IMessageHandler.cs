using TauCode.Messaging.Abstractions;

namespace TauCode.Messaging;

public interface IMessageHandler
{
    Task HandleAsync(IMessage message, CancellationToken cancellationToken = default);
}