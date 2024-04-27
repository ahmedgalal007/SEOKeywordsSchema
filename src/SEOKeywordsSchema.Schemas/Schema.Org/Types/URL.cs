using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types;
[EntityTypeConfiguration(typeof(TypeConfigurationBase<URL>))]
public class URL : ValueObject, ISchemaType<URL>, 
                    IValuesMember<URL>,
                    IEquatable<URL>, IEquatable<Text>, IEquatable<string>
{
    public URL() { }
    public URL(string value) { Value = new Uri(value); }

    public Uri Value { get; set; }
    public DefaultIdType Id { get; set; }

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

    public URL Update(URL value)
    {
        Value = value.Value;
        return this;
    }

    public URL Delete(DefaultIdType id)
    {
        return this;
    }

    public static string Help() => "Url";

    public static implicit operator URL(string value)
    {
        return new URL(value);
    }

    public static implicit operator URL(Text text)
    {
        return new URL(text.Value);
    }
}
