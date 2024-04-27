using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles;
public class Rating : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Rating);
}


// TODO AggregateRating
// TODO EndorsementRating