using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Types.MixedTypes;
using SEOKeywordsSchema.Schemas.Types;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Image>))]
public class Image : ImageObjectOrURL, ISchemaProperty<Image>
{
    protected Image() { }
    public Image(URL value2) : base(value2)
    {
    }
}
