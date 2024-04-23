using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;

namespace SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<URL>))]
public class URL : ValueObjectWithId, IEquatable<URL>, IEquatable<Text>, IEquatable<string>
{
    public URL() { }
    public URL(string value) { Value = new Uri(value); }
    public Uri Value { get; set; }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override bool Equals(object? obj)
    {
        if (base.Equals(obj)) return true;

        return obj != null && obj.Equals(this);
    }

    public string GetCleanUri() => Value.AbsoluteUri.TrimEnd('/').ToLower();
    public bool Equals(string? other)
    {
        return string.Equals(GetCleanUri(), other);
    }

    public bool Equals(URL? other)
    {
        if (base.Equals(other)) return true;
        if (string.Equals(Value.AbsoluteUri, other?.Value.AbsoluteUri)) return true;
        return false;
    }

    public bool Equals(Text? other)
    {
        if (base.Equals(other)) return true;
        if (string.Equals(Value.AbsoluteUri, other?.Value)) return true;
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
