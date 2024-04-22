using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
using SEOKeywordsSchema.Schemas.Things;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
// [Owned]
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Text>))]
public class Text : ValueObjectWithId, IEquatable<Text>, IEquatable<URL>, IEquatable<string>
{
    private Text() { }
    public Text(string value)
    {
        Value = value;
    }
    public string Value { get; set; } = string.Empty;

    protected override IEnumerable<Text> GetEqualityComponents()
    {
        yield return Value;
    }
    public override bool Equals(object? obj)
    {
        if (base.Equals(obj)) return true;

        if (obj.GetType() == typeof(string))
            return string.Equals(Value, (string)obj);

        return false;
    }


    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public Boolean Equals(Text? other)
    {
        return Id == other.Id;
    }

    public Boolean Equals(String? other)
    {
        return !string.IsNullOrEmpty(other) && !string.IsNullOrWhiteSpace(other) && Value == other;
    }

    public Boolean Equals(URL? other)
    {
        return other != null && other.Value?.AbsoluteUri?.TrimEnd('/').ToLower() == Value?.TrimEnd('/').ToLower();
    }

    public static implicit operator Text(string value)
    {
        return new Text(value);
    }

    public static implicit operator Text(URL url)
    {
        return new Text(url.GetCleanUri());
    }
}
