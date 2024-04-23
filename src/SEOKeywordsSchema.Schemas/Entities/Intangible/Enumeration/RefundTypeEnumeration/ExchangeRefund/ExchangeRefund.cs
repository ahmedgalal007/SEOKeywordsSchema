using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.RefundTypeEnumerations;
public class ExchangeRefund : RefundTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ExchangeRefund);
}
