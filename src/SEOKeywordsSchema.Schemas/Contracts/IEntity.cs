namespace SEOKeywordsSchema.Schemas.Contracts;

public interface IEntity
{
    List<DomainEvent> DomainEvents { get; }
}

public interface IEntity<TId> : IEntity
{
    TId Id { get; }
}