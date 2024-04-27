using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Reviews;
public class UserReview : Review
{
    public override string TypeName { get; protected set; } = nameof(UserReview);
}
