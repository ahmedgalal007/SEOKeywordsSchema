using System;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.Reviews;
public class ClaimReview : Review
{
    public override string TypeName { get; protected set; } = nameof(ClaimReview);
}
