namespace SEOKeywordsSchema.Schemas.Contracts;
public abstract class EntityValueObject : BaseEntity, IEquatable<EntityValueObject>
{
    public abstract IEnumerable<object> GetAtomicValues();

    public override int GetHashCode()
    {
        return GetAtomicValues()
            .Aggregate(
                default(int),
                HashCode.Combine);
    }

    private bool ValuesAreEquales(EntityValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }

    public override bool Equals(object? obj)
    {
        return obj is EntityValueObject other && ValuesAreEquales(other);
    }

    public bool Equals(EntityValueObject? other)
    {
        return other is not null && ValuesAreEquales(other);
    }
}
