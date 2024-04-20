using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;

public class SubjectOf : TwoValues<CreativeWork, Event>
{
    public SubjectOf()
    {
        
    }

    public SubjectOf(CreativeWork value1) : base(value1)
    {
    }
    public SubjectOf(Event value2) : base(value2)
    {
    }
}
