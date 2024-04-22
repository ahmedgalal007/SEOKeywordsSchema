using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<URL>))]
public class URL : ValueObjectWithId, IEquatable<URL>, IEquatable<Text>, IEquatable<string>
{
    public URL() { }
    public URL(string value) { Value = new Uri(value); }
    public Uri Value { get; set; }
    protected override IEnumerable<Object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override bool Equals(object? obj)
    {
        if (base.Equals(obj)) return true;

        return obj != null && obj.Equals(this);
    }

    public string GetCleanUri() => Value.AbsoluteUri.TrimEnd('/').ToLower();
    public Boolean Equals(String? other)
    {
        return String.Equals(GetCleanUri(), other);
    }

    public Boolean Equals(URL? other)
    {
        if (base.Equals(other)) return true;
        if(String.Equals(Value.AbsoluteUri, other?.Value.AbsoluteUri)) return true;
        return false;
    }

    public Boolean Equals(Text? other)
    {
        if (base.Equals(other)) return true;
        if (String.Equals(Value.AbsoluteUri, other?.Value)) return true;
        return false;
    }

    public static implicit operator URL(string value)
    {
        return new URL(value);
    }

    public static implicit operator URL(Text text)
    {
        return new URL(text.Value);
    }
}
