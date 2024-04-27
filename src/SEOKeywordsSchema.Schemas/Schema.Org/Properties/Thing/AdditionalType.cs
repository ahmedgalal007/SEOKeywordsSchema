using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<AdditionalType>))]
public class AdditionalType : TextOrURL, ISchemaProperty<AdditionalType>
{
    protected AdditionalType() { }
    public AdditionalType(string value1) : base(new Text(value1)) { }
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