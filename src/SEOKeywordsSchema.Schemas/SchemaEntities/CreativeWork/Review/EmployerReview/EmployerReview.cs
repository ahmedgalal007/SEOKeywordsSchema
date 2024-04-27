using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Reviews;
public class EmployerReview : Review
{
    public override string TypeName { get; protected set; } = nameof(EmployerReview);
}
