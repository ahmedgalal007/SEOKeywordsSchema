using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.CriticReview;
public class CriticReview : Review
{
    public override string TypeName { get; protected set; } = nameof(CriticReview);
}
