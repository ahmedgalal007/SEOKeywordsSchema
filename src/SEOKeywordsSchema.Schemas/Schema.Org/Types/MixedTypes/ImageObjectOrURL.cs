using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.MediaObject.ImageObject;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;
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


