using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.CriticReview;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.CriticReview.ReviewNewsArticle;
public class ReviewNewsArticle : CriticReview
{
    public override string TypeName { get; protected set; } = nameof(ReviewNewsArticle);
}
