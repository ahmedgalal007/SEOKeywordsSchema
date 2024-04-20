using SEOKeywordsSchema.Schemas.Events;

namespace SEOKeywordsSchema.Schemas.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}