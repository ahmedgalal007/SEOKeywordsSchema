
using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;

public class MainEntityOfPage : TwoValues<CreativeWork, Uri>
{
    public MainEntityOfPage(CreativeWork value1) : base(value1)
    {
    }
    public MainEntityOfPage(Uri value2) : base(value2)
    {
    }
}
