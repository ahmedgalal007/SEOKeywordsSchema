using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations;
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