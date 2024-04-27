using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Rating;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Rating.AggregateRating;
public class AggregateRating : Rating
{
    public override string TypeName { get; protected set; } = nameof(AggregateRating);
}
