using TauCode.Messaging.Abstractions;
using TauCode.Working;

namespace TauCode.Messaging;

public interface IMessagePublisher : IWorker
{
    void Publish(IMessage message);
}