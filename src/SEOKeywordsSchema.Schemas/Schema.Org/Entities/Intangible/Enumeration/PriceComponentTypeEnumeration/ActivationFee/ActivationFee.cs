using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceComponentTypeEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceComponentTypeEnumeration.ActivationFee;
public class ActivationFee : PriceComponentTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ActivationFee);
}
