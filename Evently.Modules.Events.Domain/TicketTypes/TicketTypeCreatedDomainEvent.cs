using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.TicketTypes;

public sealed class TicketTypeCreatedDomainEvent : DomainEvent
{
    public TicketTypeCreatedDomainEvent(Guid ticketTypeId)
    {
        TicketTypeId = ticketTypeId;
    }

    public Guid TicketTypeId { get; init; }
}
