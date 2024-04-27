using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review.EmployerReview;
public class EmployerReview : Review
{
    public override string TypeName { get; protected set; } = nameof(EmployerReview);
}
