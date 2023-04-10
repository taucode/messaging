namespace TauCode.Messaging.EasyNetQ;

public interface IEasyNetQMessagePublisher : IMessagePublisher
{
    string? ConnectionString { get; set; }
}