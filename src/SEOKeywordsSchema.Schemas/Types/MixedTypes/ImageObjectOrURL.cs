using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.MediaObjects;
using SEOKeywordsSchema.Schemas.Types;

namespace SEOKeywordsSchema.Schemas.Types.MixedTypes;
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


