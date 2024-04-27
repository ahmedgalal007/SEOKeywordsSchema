using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.PaymentStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.PaymentStatusType.PaymentDue;
public class PaymentDue : PaymentStatusType
{
    public override string TypeName { get; protected set; } = nameof(PaymentDue);
}
