using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<URL>))]
public class URL : ValueObjectWithId
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
        if (obj.GetType() == typeof(Text))
            return string.Equals(Value.AbsoluteUri.TrimEnd('/').ToLower(), ((Text)obj).Value.TrimEnd('/').ToLower());

        if (obj.GetType() == typeof(string))
            return string.Equals(Value.AbsoluteUri.TrimEnd('/').ToLower(), ((string)obj).TrimEnd('/').ToLower());

        return false;
    }

    public static implicit operator URL(string value)
    {
        return new URL(value);
    }
}
