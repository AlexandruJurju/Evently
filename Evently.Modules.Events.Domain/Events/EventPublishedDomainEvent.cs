using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventPublishedDomainEvent : DomainEvent
{
    public EventPublishedDomainEvent(Guid eventId)
    {
        EventId = eventId;
    }

    public Guid EventId { get; init; }
}
