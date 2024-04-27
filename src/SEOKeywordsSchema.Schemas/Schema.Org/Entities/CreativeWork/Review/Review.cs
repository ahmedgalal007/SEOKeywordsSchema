using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Review;
public class Review : CreativeWork
{
    public override string TypeName { get; protected set; } = nameof(Review);
}


// TODO ClaimReview
// TODO CriticReview
// TODO EmployerReview
// TODO MediaReview
// TODO Recommendation
// TODO UserReview