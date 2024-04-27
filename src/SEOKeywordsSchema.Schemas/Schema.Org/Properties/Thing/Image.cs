using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Image>))]
public class Image : ImageObjectOrURL, ISchemaProperty<Image>
{
    protected Image() { }
    public Image(URL value2) : base(value2)
    {
    }
}
