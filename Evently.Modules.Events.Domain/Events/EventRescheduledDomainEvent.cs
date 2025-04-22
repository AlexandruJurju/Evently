using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventRescheduledDomainEvent : DomainEvent
{
    public EventRescheduledDomainEvent(Guid eventId, DateTime startsAtUtc, DateTime? endsAtUtc)
    {
        EventId = eventId;
        StartsAtUtc = startsAtUtc;
        EndsAtUtc = endsAtUtc;
    }

    public Guid EventId { get; }

    public DateTime StartsAtUtc { get; }

    public DateTime? EndsAtUtc { get; }
}
