using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Categories;

public sealed class CategoryNameChangedDomainEvent : DomainEvent
{
    public CategoryNameChangedDomainEvent(Guid categoryId, string name)
    {
        CategoryId = categoryId;
        Name = name;
    }

    public Guid CategoryId { get; init; }

    public string Name { get; init;  }
}
