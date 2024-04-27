using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Offers;
public class OfferForPurchase : Offer
{
    public override string TypeName { get; protected set; } = nameof(OfferForPurchase);
}
