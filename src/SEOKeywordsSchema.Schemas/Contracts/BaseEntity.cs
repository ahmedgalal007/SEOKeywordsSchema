using System.ComponentModel.DataAnnotations.Schema;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
namespace SEOKeywordsSchema.Schemas.Contracts;

public abstract class BaseEntity : BaseEntity<DefaultIdType>
{
    protected BaseEntity() { }// => Id = NewId.Next().ToGuid();
}

public abstract class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; set; } = default!;

    [NotMapped]
    public List<DomainEvent> DomainEvents { get; } = new();
}