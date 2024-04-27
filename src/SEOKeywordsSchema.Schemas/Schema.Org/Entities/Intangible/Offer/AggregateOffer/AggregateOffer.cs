using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Offer;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Offer.AggregateOffer;
public class AggregateOffer : Offer
{
    public override string TypeName { get; protected set; } = nameof(AggregateOffer);
}
