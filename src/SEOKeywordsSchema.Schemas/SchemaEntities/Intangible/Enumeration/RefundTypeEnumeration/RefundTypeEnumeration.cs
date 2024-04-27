using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations;
public class RefundTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(RefundTypeEnumeration);
}


// TODO Member ExchangeRefund
// TODO Member FullRefund
// TODO Member StoreCreditRefund