using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceTypeEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceTypeEnumeration.SalePrice;
public class SalePrice : PriceTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SalePrice);
}
