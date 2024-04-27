using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.MediaReview;
public class MediaReview : Review
{
    public override string TypeName { get; protected set; } = nameof(MediaReview);
}
