using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Reviews;
public class Recommendation : Review
{
    public override string TypeName { get; protected set; } = nameof(Recommendation);
}
