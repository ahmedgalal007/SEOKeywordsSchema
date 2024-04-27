using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.PaymentStatusType;
public class PaymentStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(PaymentStatusType);
}


// TODO Member PaymentAutomaticallyApplied
// TODO Member PaymentComplete
// TODO Member PaymentDeclined
// TODO Member PaymentDue
// TODO Member PaymentPastDue