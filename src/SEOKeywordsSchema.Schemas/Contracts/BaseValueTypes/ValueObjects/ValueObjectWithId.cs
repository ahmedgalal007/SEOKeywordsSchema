using SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TransferActions;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
public abstract class ValueObjectWithId : ValueObject, IEquatable<ValueObjectWithId>, IEquatable<ValueObject>
{
    public DefaultIdType Id { get; set; }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public virtual T Update<T>(T valueObject) where T : class { return valueObject; }

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
