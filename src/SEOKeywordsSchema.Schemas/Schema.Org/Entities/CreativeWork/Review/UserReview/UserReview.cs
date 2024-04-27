using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.UserReview;
public class UserReview : Review
{
    public override string TypeName { get; protected set; } = nameof(UserReview);
}
