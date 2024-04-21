using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes.OwnedBaseTypes;
// [Owned]
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Text>))]
public class Text : ValueObjectWithId
{
    private Text() { }
    public Text(string value)
    {
        Value = value;
    }
    public string Value { get; set; } = string.Empty;
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    public override bool Equals(object? obj)
    {
        if (base.Equals(obj)) return true;
        if(obj.GetType() == typeof(string))
            return string.Equals(Value, (string)obj);
        if (obj.GetType() == typeof(URL))
            return string.Equals(Value.TrimEnd('/').ToLower(), ((URL)obj).Value.AbsoluteUri.TrimEnd('/').ToLower());

        
        return false;

        return false;
    }

    public static implicit operator Text(string value)
    {
        return new Text(value);
    }
}
