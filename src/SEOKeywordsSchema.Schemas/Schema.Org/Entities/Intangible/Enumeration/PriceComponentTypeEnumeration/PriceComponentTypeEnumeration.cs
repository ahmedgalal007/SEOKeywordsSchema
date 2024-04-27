using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceComponentTypeEnumeration;
public class PriceComponentTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(PriceComponentTypeEnumeration);
}


// TODO ActivationFee
// TODO CleaningFee
// TODO DistanceFee
// TODO Downpayment
// TODO Installment
// TODO Subscription