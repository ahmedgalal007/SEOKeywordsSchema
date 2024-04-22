using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Property;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<AdditionalType>))]
public class AdditionalType : TextOrURL
{
    protected AdditionalType() { }
    public AdditionalType(Text value1) : base(value1) { }
    public AdditionalType(URL value2) : base(value2) { }

    public static bool operator ==(AdditionalType type, string str)
    {
        return type.Equals(str);
    }
    public static bool operator !=(AdditionalType type, string str)
    {
        return !type.Equals(str);
    }

    public static implicit operator AdditionalType(Text value)
    {
        return new AdditionalType(value);
    }

    public static implicit operator AdditionalType(URL value)
    {
        return new AdditionalType(value);
    }
}