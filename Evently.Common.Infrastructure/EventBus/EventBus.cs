﻿using Evently.Common.Application.EventBus;
using MassTransit;

namespace Evently.Common.Infrastructure.EventBus;

internal sealed class EventBus(
    IBus bus
)
    : IEventBus
{
    public async Task PublishAsync<T>(T integrationEvent, CancellationToken cancellationToken = default)
        where T : IIntegrationEvent
    {
        await bus.Publish(integrationEvent, cancellationToken);
    }
}
