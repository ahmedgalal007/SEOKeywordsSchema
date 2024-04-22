using SEOKeywordsSchema.Schemas.Things.Actions.TransferActions;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
public abstract class ValueObjectWithId : ValueObject, IEquatable<ValueObjectWithId>, IEquatable<ValueObject>
{
    public DefaultIdType Id { get; set; }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public Boolean Equals(ValueObjectWithId? other)
    {
        if (base.Equals(other)) return true;
        if (other != null) return Id != default && Id.Equals(other.Id);
        return false;
    }

    public Boolean Equals(ValueObject? other)
    {
        return base.Equals(other);
    }
}
