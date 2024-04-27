namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
public abstract class ValueObject : IEquatable<ValueObject?>, IEquatable<Object?>
{
    protected abstract IEnumerable<object> GetEqualityComponents();

    public override int GetHashCode()
    {
        // return GetAtomicValues()
        //     .Aggregate(
        //         default(int),
        //         HashCode.Combine);
        return GetEqualityComponents()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

   
    protected static bool EqualOperator(ValueObject left, ValueObject right)
    {
        if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
        {
            return false;
        }
        return ReferenceEquals(left, right) || left.Equals(right);
    }

    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
        return !EqualOperator(left, right);
    }

    public Boolean Equals(ValueObject? other)
    {
        return Equals(other);
    }

    public override Boolean Equals(Object? other)
    {
        // return base.Equals(other);
        if (other is null) return false;
        if(other.GetType().Equals(GetType()))
                return EqualOperator(this, (ValueObject)other);
        return false;
    }

    //public bool Equals(ValueObject? other)
    //{
    //    return other is not null && Equals(other);
    //}

    public static bool operator ==(ValueObject one, ValueObject two)
    {
        return EqualOperator(one, two);
    }

    public static bool operator !=(ValueObject one, ValueObject two)
    {
        return NotEqualOperator(one, two);
    }
}