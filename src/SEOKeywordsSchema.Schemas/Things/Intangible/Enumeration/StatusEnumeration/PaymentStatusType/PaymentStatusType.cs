using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class PaymentStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(PaymentStatusType);
}


// TODO Member PaymentAutomaticallyApplied
// TODO Member PaymentComplete
// TODO Member PaymentDeclined
// TODO Member PaymentDue
// TODO Member PaymentPastDue