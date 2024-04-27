using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RefundTypeEnumeration;
public class RefundTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(RefundTypeEnumeration);
}


// TODO Member ExchangeRefund
// TODO Member FullRefund
// TODO Member StoreCreditRefund