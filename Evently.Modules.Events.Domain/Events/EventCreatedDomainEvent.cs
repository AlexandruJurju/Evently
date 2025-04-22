using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventCreatedDomainEvent : DomainEvent
{
    public EventCreatedDomainEvent(Guid eventId)
    {
        EventId = eventId;
    }

    public Guid EventId { get; init; }
}
