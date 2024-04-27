using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.Recommendation;
public class Recommendation : Review
{
    public override string TypeName { get; protected set; } = nameof(Recommendation);
}
