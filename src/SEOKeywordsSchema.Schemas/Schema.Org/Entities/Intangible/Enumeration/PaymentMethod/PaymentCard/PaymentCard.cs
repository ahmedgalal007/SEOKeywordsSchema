using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PaymentMethod;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.PaymentMethod.PaymentCard;
public class PaymentCard : PaymentMethod
{
    public override string TypeName { get; protected set; } = nameof(PaymentCard);
}

// TODO CreditCard