using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.OfferItemCondition;
public class OfferItemCondition : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(OfferItemCondition);
}


// TODO Member DamagedCondition
// TODO Member NewCondition
// TODO Member RefurbishedCondition
// TODO Member UsedCondition