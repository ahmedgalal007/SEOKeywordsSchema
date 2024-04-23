using SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
public abstract class ValueObjectWithId : ValueObject, IEquatable<ValueObjectWithId>, IEquatable<ValueObject>
{
    public DefaultIdType Id { get; set; }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public bool Equals(ValueObjectWithId? other)
    {
        if (base.Equals(other)) return true;
        if (other != null) return Id != default && Id.Equals(other.Id);
        return false;
    }

    public bool Equals(ValueObject? other)
    {
        return base.Equals(other);
    }
}
