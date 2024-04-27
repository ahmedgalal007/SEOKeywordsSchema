using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Rating;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Rating.EndorsementRating;
public class EndorsementRating : Rating
{
    public override string TypeName { get; protected set; } = nameof(EndorsementRating);
}
