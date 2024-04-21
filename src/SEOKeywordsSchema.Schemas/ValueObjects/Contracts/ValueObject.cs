namespace SEOKeywordsSchema.Schemas.ValueObjects.Contracts;
public abstract class ValueObject : IEquatable<object?>
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
        return !(EqualOperator(left, right));
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (ReferenceEquals(this, obj)) return true;

        var other = (ValueObject)obj;

        return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());

    }

    //public Boolean Equals(ValueObject? other)
    //{
    //    return Equals(other);
    //}

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

public abstract class ValueObjectWithId : ValueObject {
    public DefaultIdType Id { get; set; }
    public override bool Equals(object? obj)
    {
        if(base.Equals(obj)) return true;
        if (obj.GetType().IsAssignableTo(GetType()))
        {
            var other = (ValueObjectWithId)obj;
            return (this.Id != default) && (this.Id.Equals(other.Id));
        }
        return false;
    }
}
