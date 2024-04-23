using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Reviews;
public class MediaReview : Review
{
    public override string TypeName { get; protected set; } = nameof(MediaReview);
}
