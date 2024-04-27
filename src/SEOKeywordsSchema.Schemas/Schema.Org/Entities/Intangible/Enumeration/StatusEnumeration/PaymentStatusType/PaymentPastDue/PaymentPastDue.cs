using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.PaymentStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.PaymentStatusType.PaymentPastDue;
public class PaymentPastDue : PaymentStatusType
{
    public override string TypeName { get; protected set; } = nameof(PaymentPastDue);
}
