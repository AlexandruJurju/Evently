using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.Categories;

public sealed class CategoryCreatedDomainEvent : DomainEvent
{
    public CategoryCreatedDomainEvent(Guid categoryId)
    {
        CategoryId = categoryId;
    }

    public Guid CategoryId { get; init; }
}
