using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Ratings;
public class AggregateRating : Rating
{
    public override string TypeName { get; protected set; } = nameof(AggregateRating);
}
