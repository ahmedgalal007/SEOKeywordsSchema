using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks.MediaObjects;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
public class ImageObjectOrURL : TwoValues<ImageObject, URL>
{
    protected ImageObjectOrURL() { }
    public ImageObjectOrURL(ImageObject value1) : base(value1)
    {
    }
    public ImageObjectOrURL(URL value2) : base(value2)
    {
    }
}


[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Image>))]
public class Image : ImageObjectOrURL
{
    protected Image() { }
    public Image(URL value2) : base(value2)
    {
    }
}