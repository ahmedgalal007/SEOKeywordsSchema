using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PriceTypeEnumeration;
public class PriceTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(PriceTypeEnumeration);
}


// TODO Member InvoicePrice
// TODO Member ListPrice
// TODO Member MSRP
// TODO Member MinimumAdvertisedPrice
// TODO Member SRP
// TODO Member SalePrice