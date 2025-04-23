using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.Categories;

public sealed class CategoryArchivedDomainEvent : DomainEvent
{
    public CategoryArchivedDomainEvent(Guid categoryId)
    {
        CategoryId = categoryId;
    }

    public Guid CategoryId { get; init; }
}
