using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.SchemaEntities;
using SEOKeywordsSchema.Schemas.Types;

namespace SEOKeywordsSchema.Schemas.Types.MixedTypes;
public class CreativeWorkOrURL : TwoValues<CreativeWork, URL>
{
    protected CreativeWorkOrURL() { }
    public CreativeWorkOrURL(CreativeWork value1) : base(value1)
    {
    }
    public CreativeWorkOrURL(URL value2) : base(value2)
    {
    }

}





