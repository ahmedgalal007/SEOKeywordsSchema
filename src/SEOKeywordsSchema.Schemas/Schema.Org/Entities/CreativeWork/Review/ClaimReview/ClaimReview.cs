using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.ClaimReview;
public class ClaimReview : Review
{
    public override string TypeName { get; protected set; } = nameof(ClaimReview);
}
