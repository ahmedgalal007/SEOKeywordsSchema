using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Reviews.CriticReviews;
public class ReviewNewsArticle: CriticReview
{
    public override string TypeName { get; protected set; } = nameof(ReviewNewsArticle);
}
