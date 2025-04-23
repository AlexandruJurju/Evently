using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventCanceledDomainEvent : DomainEvent
{
    public EventCanceledDomainEvent(Guid eventId)
    {
        EventId = eventId;
    }

    public Guid EventId { get; init; }
}
