﻿namespace TauCode.Messaging;

public interface IMessageHandler<in TMessage> : IMessageHandler
    where TMessage : class, IMessage
{
    Task HandleAsync(TMessage message, CancellationToken cancellationToken = default);
}