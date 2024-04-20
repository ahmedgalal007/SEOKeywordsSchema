using SEOKeywordsSchema.Schemas.Contracts;
using SEOKeywordsSchema.Schemas.Things;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;
public interface IProperty { Guid Id { get;} }
public class Property<T> : EntityValueObject
    where T : IProperty
{
    public const int MaxLength = 50;
    protected Property(T value)
    {
        // if (!CheckValueIsAllowed(value))
        // {
        //     throw new ArgumentException($"The value Type <{value.GetType().Name}> should be one of {string.Join(',',  AcceptedTypes.Select(e => e.GetType().Name))}");
        // }

        Ref = value.Id;
        IsRef = true;
    }

    protected Property(string value)
    {
        if(!string.IsNullOrWhiteSpace(value)) Value = value;
    }

    public string Value { get; private set; }
    public bool IsRef { get; private set; } = false;
    public Guid? Ref { get; private set; }

    public static Result<Property<T>> Create(T name)
    {
        if (name.GetType().IsAssignableFrom(typeof(Thing)))
        {
            return Result.Failure<Property<T>>(new Error(
                "Property.NotAllowed",
                "Propert value must be <simple> or driven from <Thing> class ."));
        }

        return new Property<T>(name);
    }
    public static Result<Property<T>> Create(string name)
    {
        return new Property<T>(name);
    }

    public virtual bool Equals(Property<T>? other)
    {
        if (IsRef) return Ref == other.Ref;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is Property<T> property && property.Equals(this);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return IsRef ? Ref.ToString() : Value;
    }

    public override string ToString()
    {
        return IsRef ? Ref.ToString() : Value;
    }
}
