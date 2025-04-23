using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.TicketTypes;

public sealed class TicketTypePriceChangedDomainEvent : DomainEvent
{
    public TicketTypePriceChangedDomainEvent(Guid ticketTypeId, decimal price)
    {
        TicketTypeId = ticketTypeId;
        Price = price;
    }

    public Guid TicketTypeId { get; init; }

    public decimal Price { get; init; }
}
